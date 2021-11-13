using System;
using System.Data.Entity;
using System.Linq;

namespace Desafio3DSE.Models
{
    public class CRUD : DbContext
    {
        // El contexto se ha configurado para usar una cadena de conexión 'CRUD' del archivo 
        // de configuración de la aplicación (App.config o Web.config). De forma predeterminada, 
        // esta cadena de conexión tiene como destino la base de datos 'Desafio3DSE.Models.CRUD' de la instancia LocalDb. 
        // 
        // Si desea tener como destino una base de datos y/o un proveedor de base de datos diferente, 
        // modifique la cadena de conexión 'CRUD'  en el archivo de configuración de la aplicación.
        public CRUD()
            : base("name=CRUD")
        {
        }

        // Agregue un DbSet para cada tipo de entidad que desee incluir en el modelo. Para obtener más información 
        // sobre cómo configurar y usar un modelo Code First, vea http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Clientes> clientes { get; set; }
        public virtual DbSet<Productos> productos { get; set; }
        public virtual DbSet<Pedidos> pedidos { get; set; }

    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}