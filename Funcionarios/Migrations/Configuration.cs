namespace Funcionarios.Migrations
{
    using System;
    using System.Collections.Generic;
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


            var Funcionario = new Funcionarios.Funcionario()
            {
                Nome = "Fulano de Tal",
                CPF = "111.111.111-22",
                Admissao = new DateTime(2018, 01, 01)
            };
            Funcionario.Lotacoes = new List<Lotacao>();
            Departamento departamento = context.
                Departamentos.Where(d =>
                    d.Nome.Contains("Banco de Dados")).
                    FirstOrDefault();
            Lotacao l1 = new Lotacao();
            l1.Cargo = DBA;
            l1.Departamento = departamento;
            l1.Inicio = new DateTime(2018, 01, 01);
            l1.Fim = new DateTime(2018, 12, 31);
            Funcionario.Lotacoes.Add(l1);

            Lotacao l2 = new Lotacao();
            l2.Cargo = programador;
            l2.Departamento = departamento;
            l2.Inicio = new DateTime(2019, 01, 01);
            Funcionario.Lotacoes.Add(l2);
            AdicionarFuncionarioBanco(context,Funcionario);
        context.SaveChanges();
        }

        private static void AdicionarFuncionarioBanco(ModelFuncionarios context,
            Funcionario f)
        {
            Funcionario funcionario =
                            (from frc in context.Funcionarios
                             where frc.Nome == f.Nome
                             select frc).FirstOrDefault();
            if (funcionario == null)
            {
                context.Funcionarios.Add(f);
            }
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
