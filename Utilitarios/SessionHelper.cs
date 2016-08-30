using System.Web;

namespace Amf.Framework.Utilitarios
{
    public static class SessionHelper
    {
        public static T Obter<T>(string nomeSession)
        {
            return (T)HttpContext.Current.Session[nomeSession];
        }

        public static T ObterComDefault<T>(string nomeSession)
        {
            object valor = HttpContext.Current.Session[nomeSession];

            return valor == null ? default(T) : ((T)valor);
        }

        public static void Atualiza(string nomeSession, object valor)
        {
            HttpContext.Current.Session[nomeSession] = valor;
        }


        public static void Abandon()
        {
            HttpContext.Current.Session.Abandon();
        }

        public static void RemoveAll()
        {
            HttpContext.Current.Session.RemoveAll();
        }
    }
}
