using System;
using System.Collections.Generic;
using System.IO;
using RoletopMVC.Enums;
using RoletopMVC.Models;
using RoletopMVC.ViewModels;

namespace RoletopMVC.Repositories {
    public class PedidoRepository : RepositoryBase {

        ClienteRepository clienteRepository = new ClienteRepository();
        private const string PATH = "Database/Pedido.csv";
        public PedidoRepository () {
            if (!File.Exists (PATH)) {
                File.Create (PATH).Close ();
            }

        }
        public bool Inserir (Pedido pedido) {
            var quantidadePedidos = File.ReadAllLines(PATH).Length;
            pedido.Id = (ulong) ++quantidadePedidos;
            var linha = new string[] { PrepararPedidoCSV (pedido) };
            File.AppendAllLines (PATH, linha);

            return true;
        }

        public List<Pedido> ObterTodosPorCliente(string emailCliente)
        {
            var pedidos = ObterTodos();
            List<Pedido> pedidosCliente = new List<Pedido>();

            foreach (var pedido in pedidos)
            {
                if(pedido.Cliente.Email.Equals(emailCliente))
                {
                    pedidosCliente.Add(pedido);
                }
            }
            return pedidosCliente;
        }

        public List<Pedido> ObterTodos () {
            var linhas = File.ReadAllLines (PATH);
            List<Pedido> pedidos = new List<Pedido>();

            foreach (var linha in linhas) {
                Pedido pedido = new Pedido ();


                pedido.Id = ulong.Parse(ExtrairValorDoCampo("id", linha));
                pedido.Status = uint.Parse(ExtrairValorDoCampo("status_pedido", linha));
                pedido.Nome = ExtrairValorDoCampo("nome", linha);
                pedido.Email = ExtrairValorDoCampo("email", linha);
                pedido.DataDoEvento = DateTime.Parse(ExtrairValorDoCampo("data_pedido", linha));
                pedido.RG = ExtrairValorDoCampo("rg", linha);
                pedido.CPF = ExtrairValorDoCampo("cpf", linha);
                pedido.FormaPagamento = ExtrairValorDoCampo("forma_pagamento", linha);
                pedido.LuzSom = ExtrairValorDoCampo("ls",linha);
                pedido.Pergunta = ExtrairValorDoCampo("pergunta",linha);
                pedido.Descricao = ExtrairValorDoCampo("descricao", linha);
                
                pedido.Cliente = clienteRepository.ObterPor(pedido.Email);


                pedidos.Add(pedido);
            }
            return pedidos;
        }

        public Pedido ObterPor(ulong id)
        {
            var pedidosTotais = ObterTodos();
            foreach (var pedido in pedidosTotais)
            {
                if(id.Equals(pedido.Id))
                {
                    return pedido;
                }
            }
            return null;
        }

        public bool Atualizar(Pedido pedido)
        {
            var pedidosTotais = File.ReadAllLines(PATH);
            var pedidoCSV = PrepararPedidoCSV(pedido);
            var linhaPedido = -1;
            var resultado = false;
            
            for (int i = 0; i < pedidosTotais.Length; i++)
            {
                var idConvertido = ulong.Parse(ExtrairValorDoCampo("id", pedidosTotais[i]));
                if(pedido.Id.Equals(idConvertido))
                {
                    linhaPedido = i;
                    resultado = true;
                    break;
                }
            }

            if(resultado)
            {
                pedidosTotais[linhaPedido] = pedidoCSV;
                File.WriteAllLines(PATH, pedidosTotais);
            }

            return resultado;
        }

        private string PrepararPedidoCSV (Pedido pedido) {

            return $"id={pedido.Id};status_pedido={pedido.Status};nome={pedido.Nome};email={pedido.Email};cpf={pedido.CPF};rg={pedido.RG};data_pedido={pedido.DataDoEvento};forma_pagamento={pedido.FormaPagamento};ls={pedido.LuzSom};descricao={pedido.Descricao};pergunta={pedido.Pergunta};";
        }
    }
}

