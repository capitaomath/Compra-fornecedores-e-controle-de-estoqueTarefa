using System;
using System.Collections.Generic;

namespace Aula14
{
    class Program
    {
           public static void Main(string[] args)
          {                 
                bool MostrarMenu = true;
                while (MostrarMenu)
                {
                    MostrarMenu = MenuPrincipal();
                }
          }




          private static bool MenuPrincipal()
            {

                Console.Clear();
               
                Console.WriteLine("Aperte '2' para visualizar o exercício (1) e (2).");
                Console.WriteLine("Aperte '3' para visualizar o exercício (3)");
                Console.WriteLine("Aperte '4' para visualizar o exercício (4).");
                Console.WriteLine("Aperte '5' para visualizar o exercício (5).");
                Console.WriteLine("Aperte '6' para visualizar o código padrão (6).");
                Console.WriteLine("Aperte '7' para fechar o programa.");
              
                switch (Console.ReadLine())
                {
                        
                        case "2":
                            Console.Clear();
                            
                            Fornecedor Fornecedor_ = new Fornecedor( "Neymar", "45.696.940/0001-03");
                            
                            Produto ProdutoFisico = new ProdutoFisico("Playstation 5", 5000, 10.99, Fornecedor_);                     
                            ProdutoFisico.Imprimir();   
                            Console.WriteLine("Aperte qualtquer tecla para sair");
                            Console.ReadKey();
                            
                        return true;




                        case "3":   
                             Console.Clear();
                            
        
                            Licensa RTX_3080 = new Licensa("RTX3080", 14000.00, "ZTGH-PALY-MCLK-12MS");
                            Estoque  Estoque_ = new Estoque();
                        
                            for(int i = 0; i < 5; i++)
                            {
                            Estoque_.Adicionar(RTX_3080);
                            }
                    
                            for(int i = 0; i < 3; i++)
                            {
                            Estoque_.Remover(RTX_3080);
                            }
                        
                           
                            Estoque_.ImprimirEstoque();
                            
                      
                            Console.WriteLine("Aperte qualquer tecla para sair");
                            Console.ReadKey();
                          
                        return true;



                        
                        case "4":
                                 Console.Clear();
                                
                                Licensa Memoria_3tb = new Licensa("Memória 3Tb", 1500.00, "XZLT-CXL9-SLHV-99UM");
                                Licensa Ratatouille = new Licensa("Ratatouille", 100.90, "XZLT-CXL9-SLHV-99UM");
                            
                                Carrinho Carrinho = new Carrinho();
                                Estoque Estoque_3 = new Estoque();


                                for(int i = 0; i < 5; i++)
                                {
                                    Carrinho.Adicionar(Memoria_3tb);
                                }
                                    for(int i = 0; i < 3; i++)
                                {
                                    Carrinho.Adicionar(Ratatouille);
                                }


                                for(int i = 0; i < 5; i++)
                                {
                                Estoque_3.Adicionar(Memoria_3tb);
                                Estoque_3.Adicionar(Ratatouille);
                                }

                                Cliente Cliente_ = new Cliente(nome: "Albert Einsten", cpf: "777.598.354-51");
                                Compras Compras = new Compras( carrinho_ : Carrinho, estoque_: Estoque_3, cliente_ : Cliente_);
                             
                                Compras.Comprar_Produtos();
                                
                                Compras.ImprimirRecibo();
                                
                                Console.WriteLine("Aperte qualtquer tecla para sair");
                                Console.ReadKey();
                              
                        return true;




                        case "5":
                           Console.Clear();
                           
                            Fornecedor Fornecedor_02 = new Fornecedor("Produtos oficiais confia", "45.696.940/0001-03");
                            Fornecedor Fornecedor_03 = new Fornecedor("camelô só que original", "45.696.940/0001-03");
                
                            Relatorio Fornecedores_relatorio = new Relatorio(

                                titulo : "Compras dos Fornecedores",
                                descricao : "Mostrando fornecedores"

                            );

                    Fornecedores_relatorio.AdicionarItem(Fornecedor_02);
                    Fornecedores_relatorio.AdicionarItem(Fornecedor_03);
                    Fornecedores_relatorio.ImprimirRelatorio();
                
                
                            Licensa produto_02 = new Licensa("camisa ardidas", 100.90, "XZLT-CXL9-SLHV-99UM");
                            Licensa produto_03 = new Licensa("tênis Airjonas", 200.90, "XZLT-CXL9-SLHV-99UM");
                            Relatorio relatorioLicencas = new Relatorio(

                                titulo : "Relatorio das Compras",
                                descricao : "Mostrando as compras"

                            );

                            relatorioLicencas.AdicionarItem(produto_02);
                            relatorioLicencas.AdicionarItem(produto_03);
                            relatorioLicencas.ImprimirRelatorio();
                            
                            Console.WriteLine("Aperte qualquer tecla para sair");
                            Console.ReadKey();
                        
                        return true;





                        case "6":  
                                Console.Clear();                  
                                Licensa uindowns = new Licensa("uindons 12 ORIGINAL", 699.90, "SUAA-HE52-W6WG-B8Y9");
                            
                                Assinatura sono = new Assinatura("Sono Vegas", 39.90, 12, "5GNX-VM6Y-L6W8-SCPC");
                            
                                Assinatura disley = new Assinatura("Disley Plus", mensalidade: 89.90, 12, "H84A-8QDF-4XPT-A2WZ");

                                Assinatura amazoom = new Assinatura("Amazoom Praime vídeo", mensalidade: 89.90, 12, "H84A-8QDF-4XPT-A2WZ");

                                Assinatura youtubo = new Assinatura("Youtubo Premiun ", mensalidade: 89.90, 12, "RLBD-YTRZ-UPH7-VQGM");

                                Fornecedor Fornecedor_4 = new Fornecedor(nome: "Joãozinho Testes", cnpj: "45.696.940/0001-03");
                      


                                ProdutoFisico mausi = new ProdutoFisico("Mausi Michaelsóft", 89.90, 12.99, Fornecedor_4);
                                ProdutoFisico lepetope = new ProdutoFisico("Lepetope Dehul", 3499.90, 123.45, Fornecedor_4);

                                Carrinho carrinho = new Carrinho();
                    
                                carrinho.Adicionar(uindowns);
                                carrinho.Adicionar(sono, 4);
                                carrinho.Adicionar(amazoom);
                                carrinho.Adicionar(youtubo);
                                carrinho.Adicionar(disley);
                                carrinho.Adicionar(mausi, 3);
                                carrinho.Adicionar(lepetope);

                                carrinho.ImprimirCarrinho();

                                Relatorio relatorioArtistico = new Relatorio("Relatorio",
                                    "Este relatório mostra todos os softwares de streaming vendidos na loja.");
                            
                                relatorioArtistico.AdicionarItem(youtubo);
                                relatorioArtistico.AdicionarItem(amazoom);
                                relatorioArtistico.AdicionarItem(disley);
                                relatorioArtistico.ImprimirRelatorio();

                                Cliente elon = new Cliente("Elon Musk", "123.456.789-10");
                                Cliente bill = new Cliente("Bill gates", "109.876.543-21");

                                
                                Relatorio relatorioClientes = new Relatorio("Relatório de Clientes", 
                                    "Este relatório apresenta uma lista de todos os clientes que compraram no mês de abril");
                            
                                relatorioClientes.AdicionarItem(elon);
                                relatorioClientes.AdicionarItem(bill);
                                relatorioClientes.ImprimirRelatorio();
                                
                                Console.WriteLine("aperte qualquer tecla para sair");
                                Console.ReadKey();
                             
                        return true;


                        
                        case "7":
                           return false;
                           

                        
                        default:
                            return true;



                }




            }









    }
}