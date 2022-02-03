using SabadinEstoqueApi.Dominio;
using System;

namespace SabadinEstoqueApi.Aplicacao
{
    public class ResultadoOperacao
    {
        public bool Sucesso { get; set; }
        public string Mensagem { get; set; }
        public ResultadoOperacao CriarSucesso()
        {
            return new ResultadoOperacao
            {
                Sucesso = true
            };
        }

        public ResultadoOperacao CriarFalha(string mensagem)
        {
            return new ResultadoOperacao
            {
                Sucesso = false,
                Mensagem = mensagem,
            };
        }
    }

    public class ResultadoOperacao<T> : ResultadoOperacao where T : class
    {
        public T ModeloRetorno { get; set; }

        public ResultadoOperacao<T> CriarSucesso(T TModelo)
        {
            return new ResultadoOperacao<T>
            {
                Sucesso = true,
                ModeloRetorno = TModelo,
            };
        }

        public ResultadoOperacao<T> CriarSucesso(T TModelo, string mensagem)
        {
            return new ResultadoOperacao<T>
            {
                Sucesso = true,
                ModeloRetorno = TModelo,
                Mensagem = mensagem
            };
        }

        public new ResultadoOperacao<T> CriarFalha(string mensagem)
        {
            return new ResultadoOperacao<T>
            {
                Sucesso = false,
                Mensagem = mensagem,
            };
        }
    }


}
