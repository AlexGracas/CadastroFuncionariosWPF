namespace Funcionarios.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Funcionarios.ModelFuncionarios>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Funcionarios.ModelFuncionarios context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.


            Departamento dBancoDados = new Departamento()
            {
                Nome = "Departamento de Banco de Dados"
            };
            AdicionarDepartamentoBanco(context, dBancoDados);
            Departamento dDesenvolvimento = new Departamento()
            {
                Nome = "Departamento de Desenvolvimento"
            };
            AdicionarDepartamentoBanco(context, dDesenvolvimento);

            Departamento dInfraestrutura = new Departamento()
            {
                Nome = "Departamento de Infraestrutura"
            };
            AdicionarDepartamentoBanco(context, dInfraestrutura);

            Cargo programador = new Cargo()
            {
                Nome = "Programador",
                Atribuicao = "Programa Sistemas"
            };
            Cargo DBA = new Cargo()
            {
                Nome = "DBA",
                Atribuicao = "Gerencia Banco de Dados"
            };
            Cargo Operador = new Cargo()
            {
                Nome = "Operador",
                Atribuicao = "Opera computadores"
            };
            AdicionarCargoBanco(context, programador);
            AdicionarCargoBanco(context, DBA);
            AdicionarCargoBanco(context, Operador);
            context.SaveChanges();
        }

        private static void AdicionarCargoBanco(ModelFuncionarios context, 
            Cargo c)
        {
            Cargo cargo =
                            (from crg in context.Cargos
                             where crg.Nome == c.Nome
                             select crg).FirstOrDefault();
            if (cargo == null)
            {
                context.Cargos.Add(c);
            }
        }

        private static void AdicionarDepartamentoBanco(ModelFuncionarios context, Departamento dep)
        {
            Departamento departamento =
                            (from db in context.Departamentos
                             where db.Nome == dep.Nome
                             select db).FirstOrDefault();
            if (departamento == null)
            {
                context.Departamentos.Add(dep);
            }
        }
    }
}
