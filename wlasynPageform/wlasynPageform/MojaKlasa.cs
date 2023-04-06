using Soneta.Business;
using Soneta.Business.App;

using wlasynPageform;


// Sposób w jaki należy zarejestrować extender, który później zostanie użyty w interfejsie.
//[assembly: Worker(typeof(MojaKlasa))]




namespace wlasynPageform
{
    public class MojaKlasa
    {
        [Context]
        public Session Session { get; set; }

        [Context]
        public Login Login { get; set; }
    }
}
