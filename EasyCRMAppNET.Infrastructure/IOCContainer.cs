namespace EasyCRMAppNET.Infrastructure
{
    public class IOCContainer  //Register //Resolve //key-value ikilisi ile saklar //IRepository -> EFCoreRepository //ICategoryService -> CategoryService
    {
        private static readonly Dictionary<Type, Func<object>> container = new Dictionary<Type, Func<object>>();

        public static T Resolve<T>()
        {
            //var keyType = typeof(T);
            //var method = container[keyType];
            //var item = method();
            //var returnType = (T)item;
            //return returnType;

            return (T)container[typeof(T)](); // tek satırda 5 satırı kodladık
        }

        public static void Register<T>(Func<object> func)
        {
            if(container.ContainsKey(typeof(T)))
                container.Remove(typeof(T));

            container.Add(typeof(T), func);
        }

       
    }
}