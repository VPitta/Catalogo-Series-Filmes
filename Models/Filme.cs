using CatalogoDeSeries.Enum;
using System;

namespace CatalogoDeSeries.Models
{
    public class Filme : ClasseBase
    {
        public Genero Genero { get; set; }
        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
        public int Ano { get; set; }
        public bool Excluido { get; set; }

        public Filme (int id, string titulo, string descricao, Genero genero, int ano)
        {
            this.Genero = genero;
            this.Id = id;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            Console.WriteLine ($"Genero: {this.Genero}");
            Console.WriteLine ($"Titulo: {this.Titulo}");
            Console.WriteLine ($"Descrição: {this.Descricao}");
            Console.WriteLine ($"Ano de Lançamento: {this.Ano}");
            Console.WriteLine ($"Serie Excluida: {this.Excluido}");

        }

        public string? retornaTitulo()
        {
            return this.Titulo;
        }

        public int retornaId()
        {
            return this.Id;
        }

        public bool retornaExcluido()
        {
            return this.Excluido;
        }

        public void Excluir()
        {
            this.Excluido = true;
        }
    }


}