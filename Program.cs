using System;
using Blog.Data;
using Blog.Models;

namespace Blog
{
    class Program
    {

        static void Main(string[] args)
        {
            //CreateMarca();
            //UpdadeMarca();
            //DeleteMarca();
            //ListMarcas();
            ListMarca();
        }
        public static void CreateMarca()
        {
            using (var context = new DataContext())//Criando um novo item Marca.
            {
                //O context.add salva os dados em memória, ele não insere de verdade no banco.
                var marca1 = new Marca { nome = "Mondial", descricao = "Ventiladores de teto" };
                context.Marcas.Add(marca1);

                var marca2 = new Marca { nome = "FortLev", descricao = "Caixa de 1000L" };
                context.Marcas.Add(marca2);

                var marca3 = new Marca { nome = "Tramontina", descricao = "Enchada 3 Libras" };
                context.Marcas.Add(marca3);

                context.SaveChanges();//Para persisitir de verdade, precisa utilizar o SaveChanges.
                Console.WriteLine("Registro Inserido com Sucesso");

            }
        }

        public static void UpdadeMarca()
        {
            using (var context = new DataContext())
            {
                var marca = context.Marcas.FirstOrDefault(x => x.id == 5); //Atualizando um item já existente
                marca.nome = "Dell";
                marca.descricao = "DELL intel CORE I7";
                context.Update(marca);
                context.SaveChanges();
                Console.WriteLine("Registro Atualizado com Sucesso");
            }
        }
        public static void DeleteMarca()
        {
            using (var context = new DataContext())
            {
                var marca = context.Marcas.FirstOrDefault(x => x.id == 8);
                context.Remove(marca);
                context.SaveChanges();
                Console.WriteLine("Registro Excluído com Sucesso");
            }
        }
        public static void ListMarcas()
        {
            using (var context = new DataContext())
            {
                var marcas = context.Marcas.ToList();
                foreach (var item in marcas)
                {
                    Console.WriteLine("---------Todas as marcas----------");
                    Console.WriteLine(item.nome + item.descricao);
                }
            }
        }
        public static void ListMarca()
        {
            using (var context = new DataContext())
            {
                var marcas = context.Marcas;
                var marca = context.Marcas.FirstOrDefault(x => x.id == 12);
                Console.WriteLine(marca?.nome);
            }
        }
    }
}
