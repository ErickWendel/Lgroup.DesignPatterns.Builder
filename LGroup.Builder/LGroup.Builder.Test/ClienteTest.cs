using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LGroup.Builder.Model;
using LGroup.Builder.Model.Buider;

namespace LGroup.Builder.Test
{
    [TestFixture]
    public sealed class ClienteTest
    {
        [Test]
        public void Testar_Padrao_Builder_Uma_Chamada()
        {
            //Inicializamos a classe construtora
            var builderCliente = new ClienteBuilder();
            //Etapa 1
            builderCliente.SetarDadosPessoais("Zina", "zina@gmail.com", DateTime.Now);

            //Etapa 2 
            builderCliente.SetarEndereco("Rua: Teste", "0888-000", "10");

            //Etapa 3
            builderCliente.SetarTelefone("11", "98208833", "Tim");
            builderCliente.SetarTelefone("11", "98282982", "Oi");

            //Etapa 4
            builderCliente.SetarFoto("C:/fotos", "lindinhas.jpeg");
            builderCliente.SetarFoto("C:/fotos", "games.jpeg");

            //Após passar pelas etapas, retornamos o cliente construido
            var cliente = builderCliente.Gerar();
        }

        [Test]
        public void Testar_Padrao_Buider_Varias_Chamadas()
        {
            //Mais seniorzao
            var builderCliente = new ClienteBuilder();
            var cliente = builderCliente
                            .SetarDadosPessoais("Zina", "zina@gmail.com", DateTime.Now)
                            .SetarEndereco("Rua: Teste", "0888-000", "10")
                            .SetarFoto("C:/fotos", "lindinhas.jpeg")
                            .SetarTelefone("11", "98208833", "Tim")
                            .SetarTelefone("11", "98208833", "Tim")
                            .Gerar();

        }
    }
}
