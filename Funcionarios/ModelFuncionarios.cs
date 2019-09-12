namespace Funcionarios
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ModelFuncionarios : DbContext
    {
        // Your context has been configured to use a 'ModelFuncionarios' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Funcionarios.ModelFuncionarios' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ModelFuncionarios' 
        // connection string in the application configuration file.
        public ModelFuncionarios()
            : base("name=ModelFuncionarios")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Funcionario> Funcionarios{ get; set; }
        public virtual DbSet<Departamento> Departamentos { get; set; }

        public virtual DbSet<Cargo> Cargos { get; set; }
    }

}