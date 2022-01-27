using System;
using CatalogoDeSeries.Enum;
using CatalogoDeSeries.Models;
using System.Collections.Generic;

namespace CatalogoDeSeries
{
    class program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static FilmeRepositorio repositorioF = new FilmeRepositorio();
        static void Main(string[] args)
        {

            string OpcaoDoUsuario = ObterOpcaoDoUsuario();

            while (OpcaoDoUsuario.ToUpper() != "X")
            {
                switch(OpcaoDoUsuario)
                {
                    case "1":
                    OpcaoFilme();
                    break;

                    case "2":
                    OpcaoSerie();
                    break;

                }
            }

            string opcaoSerie = OpcaoSerie();
            {
            while (OpcaoDoUsuario.ToUpper() != "X")
                {
                switch(OpcaoDoUsuario)
                    {
                        case "1":
                        ListarSerie();
                        break;

                        case "2":
                        InserirSerie();
                        break;

                        case "3":
                        AtualizarSerie();
                        break;

                        case "4":
                        ExcluirSerie();
                        break;

                        case "5":
                        VisualizarSerie();
                        break;

                    }
                } 
            }

            string opcaoFilme = OpcaoFilme();
            {
            while (OpcaoDoUsuario.ToUpper() != "X")
                {
                switch(OpcaoDoUsuario)
                    {
                        case "1":
                        ListarFilme();
                        break;

                        case "2":
                        InserirFilme();
                        break;

                        case "3":
                        AtualizarFilme();
                        break;

                        case "4":
                        ExcluirFilme();
                        break;

                        case "5":
                        VisualizarFilme();
                        break;

                    }
                } 
            }
   
        }
        public static void ListarSerie()
        {
            var lista = repositorio.Lista();

            if (lista.Count == 0)
            {
               Console.WriteLine("Nehuma Serie Encontrada....");
               return; 
            }
            foreach (var serie in lista)
            {
                var excluido= serie.retornaExcluido();
                Console.WriteLine($"ID: {serie.retornaId} - {serie.retornaTitulo}.");
            }
        }
        public static void InserirSerie()
        {
            Console.WriteLine("Inserie nova Serie");

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine($"{i} - {Enum.GetName(typeof(Genero))}, i");
            }

            Console.Write("Digite o GenÊro entres as Opções Acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Titulo da Serie: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de Lançamento da Serie: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a descrição da Serie: ");
            string entradaDescricao = Console.ReadLine();

            Serie novaSerie = new Serie (id: repositorio.ProximoId(), genero: (Genero)entradaGenero, titulo: entradaTitulo, ano: entradaAno, descricao: entradaDescricao);
            repositorio.Insere(novaSerie);
        }
        public static void AtualizarSerie()
        {
            Console.WriteLine("Digite o ID da Serie: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine($"{i} - {Enum.GetName(typeof(Genero))}, i");
            }

            Console.Write("Digite o GenÊro entres as Opções Acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Titulo da Serie: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de Lançamento da Serie: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a descrição da Serie: ");
            string entradaDescricao = Console.ReadLine();

            Serie atualizaSerie = new Serie (id: repositorio.ProximoId(), genero: (Genero)entradaGenero, titulo: entradaTitulo, ano: entradaAno, descricao: entradaDescricao);
            repositorio.Atualiza(indiceSerie, atualizaSerie);
        }
       public static void ExcluirSerie()
       {
           Console.WriteLine("Digite o ID da Serie: ");
           int indiceSerie = int.Parse(Console.ReadLine());

           repositorio.Exclui(indiceSerie); 
       } 
        public static void VisualizarSerie()
       {
           Console.WriteLine("Digite o ID da Serie: ");
           int indiceSerie = int.Parse(Console.ReadLine());

           var serie = repositorio.RetornaPorId(indiceSerie);
           Console.WriteLine(serie);
        
        } 

        public static void ListarFilme()
        {
            var lista = repositorioF.Lista();

            if (lista.Count == 0)
            {
               Console.WriteLine("Nehuma Serie Encontrada....");
               return; 
            }
            foreach (var filme in lista)
            {
                var excluido = filme.retornaExcluido();
                Console.WriteLine($"ID: {filme.retornaId} - {filme.retornaTitulo}.");
            }
        }
        public static void InserirFilme()
        {
            Console.WriteLine("Inserie novo Filme");

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine($"{i} - {Enum.GetName(typeof(Genero))}, i");
            }

            Console.Write("Digite o GenÊro entres as Opções Acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Titulo do Filme: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de Lançamento do Filme: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a descrição do Filme: ");
            string entradaDescricao = Console.ReadLine();

            Filme novoFilme = new Filme (id: repositorio.ProximoId(), genero: (Genero)entradaGenero, titulo: entradaTitulo, ano: entradaAno, descricao: entradaDescricao);
            repositorioF.Insere(novoFilme);
        }
       public static void AtualizarFilme()
        {
            Console.WriteLine("Digite o ID do Filme: ");
            int indiceFilme = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine($"{i} - {Enum.GetName(typeof(Genero))}, i");
            }

            Console.Write("Digite o GenÊro entres as Opções Acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Titulo do Filme: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de Lançamento do Filme: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a descrição do Filme: ");
            string entradaDescricao = Console.ReadLine();

            Filme atualizaFilme = new Filme (id: repositorio.ProximoId(), genero: (Genero)entradaGenero, titulo: entradaTitulo, ano: entradaAno, descricao: entradaDescricao);
            repositorioF.Atualiza(indiceFilme, atualizaFilme);
        }
        public static void ExcluirFilme()
       {
           Console.WriteLine("Digite o ID do Filme: ");
           int indiceFilme = int.Parse(Console.ReadLine());

           repositorioF.Exclui(indiceFilme); 
       }  
        public static void VisualizarFilme()
       {
           Console.WriteLine("Digite o ID do Filme: ");
           int indiceFilme = int.Parse(Console.ReadLine());

           var filme = repositorioF.RetornaPorId(indiceFilme);
           Console.WriteLine(filme);
        
        } 

        public static string ObterOpcaoDoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("-----Catalogo de Series e Filmes -----");
            Console.WriteLine("Informe a Opção desejada: ");

            Console.WriteLine("1 - Série");
            Console.WriteLine("2 - Filme");
            Console.WriteLine("L - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string OpcaoDoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return OpcaoDoUsuario;

        }

        public static string OpcaoFilme()
        {
            Console.WriteLine();
            Console.WriteLine("-----Catalogo de Filmes -----");
            Console.WriteLine("Informe a Opção desejada: ");

            Console.WriteLine("1 - Lista de Filme");
            Console.WriteLine("2 - Inserir Nova Filme");
            Console.WriteLine("3 - Atualizar Filme");
            Console.WriteLine("4 - Excluir Filme");
            Console.WriteLine("5 - Visualizar Filme");
            Console.WriteLine("L - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string OpcaoFilme = Console.ReadLine().ToUpper();
            //string OpcaoDoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return OpcaoFilme;
        }

        public static string OpcaoSerie()
        {
            Console.WriteLine();
            Console.WriteLine("-----Catalogo de Filmes -----");
            Console.WriteLine("Informe a Opção desejada: ");

            Console.WriteLine("1 - Lista de Série");
            Console.WriteLine("2 - Inserir Nova Série");
            Console.WriteLine("3 - Atualizar Série");
            Console.WriteLine("4 - Excluir Série");
            Console.WriteLine("5 - Visualizar Série");
            Console.WriteLine("L - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string OpcaoSerie = Console.ReadLine().ToUpper();
            //string OpcaoDoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return OpcaoSerie;
        }

    }
}
