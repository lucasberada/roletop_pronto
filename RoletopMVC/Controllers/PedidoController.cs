using System;
using RoletopMVC.Enums;
using RoletopMVC.Models;
using RoletopMVC.Repositories;
using RoletopMVC.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoletopMVC.Controllers;

namespace RoletopMVC.Controllers {
    public class PedidoController : AbstractController {
        PedidoRepository pedidoRepository = new PedidoRepository ();

        ClienteRepository clienteRepository = new ClienteRepository();

        public IActionResult Index()
        {
            PedidoViewModel avm = new PedidoViewModel();

            var usuarioLogado = ObterUsuarioSession();
            var nomeUsuarioLogado = ObterUsuarioNomeSession();
            if(!string.IsNullOrEmpty(nomeUsuarioLogado))
            {
                avm.NomeUsuario = nomeUsuarioLogado;
                var clienteLogado = clienteRepository.ObterPor(usuarioLogado);
                avm.Cliente = clienteLogado;
            }else{
                return View(avm);
            }
            

            avm.NomeView = "Pedido";
            avm.UsuarioEmail = usuarioLogado;
            avm.UsuarioNome = nomeUsuarioLogado;

            return View(avm);

            // return View(new BaseViewModel()
            // {
            //     NomeView = "Pedido",
            //     UsuarioEmail = ObterUsuarioSession(),
            //     UsuarioNome = ObterUsuarioNomeSession()
            // });
        }
     
        public IActionResult RegistrarPedido(IFormCollection form)
        {
            ViewData["Action"] = "Pedido";
            
            try
            {
                Pedido pedido = new Pedido()
                {
                    Nome=form["nome"],
                    Email = form["email"],
                    RG=form["rg"],
                    CPF=form["cpf"],
                    Descricao=form["discricao"],
                    FormaPagamento= form["forma_pagamento"],
                    Pergunta = form["pergunta"],
                    LuzSom = form["ls"],
                    DataDoEvento = DateTime.Parse(form["data_evento"]),
                    };

                Cliente cliente = new Cliente () {
                Nome = form["nome"],
                Email = form["email"]
            };

            pedido.Cliente = cliente;


                pedidoRepository.Inserir(pedido);

               return View("Sucesso", new RespostaViewModel()
                {
                    NomeView = "Pedido",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                    
                });
            }
            catch (Exception e)
            {
                 System.Console.WriteLine(e.StackTrace);
                return View("Erro", new RespostaViewModel()
                {
                    NomeView = "Pedido",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
        }
       
        }

         public IActionResult Aprovar(ulong id)
        {
            var pedido = pedidoRepository.ObterPor(id);
            pedido.Status = (uint) StatusPedido.APROVADO;

            if(pedidoRepository.Atualizar(pedido))
            {
                return RedirectToAction("Dashboard", "Administrador");
            }
            else
            {
                return View("Erro", new RespostaViewModel("Não foi possível aprovar este pedido")
                {
                    NomeView = "Dashboard",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }

        }

        public IActionResult Reprovar(ulong id)
        {
            var pedido = pedidoRepository.ObterPor(id);
            pedido.Status = (uint) StatusPedido.REPROVADO;

            if(pedidoRepository.Atualizar(pedido))
            {
                return RedirectToAction("Dashboard", "Administrador");
            }
            else
            {
                return View("Erro", new RespostaViewModel("Não foi possível reprovar este pedido")
                {
                    NomeView = "Dashboard",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }

        }

    }
}




