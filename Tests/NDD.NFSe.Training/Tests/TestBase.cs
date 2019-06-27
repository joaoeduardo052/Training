using System;

namespace NDD.NFSe.Training.Tests
{
    public abstract class TestBase
    {
        public void ExecuteTest()
        {
            //Instancia os objetos e seta os valores nos mesmos
            Initialize();

            //Faz o setup dos mocks, definindo os retornos fixos dos métodos
            Setup();

            bool executing = true;
            try
            {
                //Executa o processo a ser testado
                When();
                executing = false;
                //valida os resultados
                Then();
            }
            catch (Exception exception)
            {
                if (executing)
                    Then(exception);
                else
                    //se cair aqui é porque a exceção foi disparada dentro do "Then"
                    throw exception;
            }
        }

        protected abstract void Initialize();
        protected abstract void Setup();
        protected abstract void When();
        protected abstract void Then(Exception triggeredException = null);
    }
}