using System.IO;
namespace RestService
{
    public class RestServiceImpl : IRestServiceImpl
    {
        #region IRestServiceImpl Members

        private bool isvalidated(string x) {
            //TO DO: ADD Authentication Logic
            var y = true;
            return y;
        }
        public string GET_xmlData(string id)
        {
            if(isvalidated(id)){
                try{
            return "You requested product " + id;
                }catch{
                    return "Oopps something went wrong";
                }
            }else{
            return "User Not authenticated";
            }
        }

        public string GET_jsonData(string id)
        {
            if(isvalidated(id)){
                try{
            return "You requested product " + id;
                }catch{
                    return "Oopps something went wrong";
                }
            }else{
            return "User Not authenticated";
            }
        }

        public string DELETE_xmlData(string id)
        {
            if(isvalidated(id)){
                try{
            return "You requested to DELETE " + id;
                }catch{
                    return "Oopps something went wrong";
                }
            }else{
            return "User Not authenticated";
            }

        }
        public string DELETE_jsonData(string id)
        {
                 if(isvalidated(id)){
                try{
            return "You requested to DELETE " + id;
                }catch{
                    return "Oopps something went wrong";
                }
            }else{
            return "User Not authenticated";
            }
        }
        public string CREATE_xmlData(string streamdata, string id)
        {
                if(isvalidated(id)){
                try{

                    return "Received: " + streamdata;
                }catch{
                    return "Oopps something went wrong";
                }
            }else{
            return "User Not authenticated";
            }
        }
        public string CREATE_jsonData(string streamdata,string age, string id)
        {
            if(isvalidated(id)){
                try{
                    return "Received: " + streamdata +" is "+ age +" years old";
                  
                }catch{
                    return "Oopps something went wrong";
                }
            }else{
            return "User Not authenticated";
            }
        }
        public string UPDATE_xmlData(string id)
        {
             if(isvalidated(id)){
                try{
            return "You requested to UPDATE " + id;
                }catch{
                    return "Oopps something went wrong";
                }
            }else{
            return "User Not authenticated";
            }
        }
        public string UPDATE_jsonData(string id)
        {
            if(isvalidated(id)){
                try{
            return "You requested to UPDATE " + id;
                }catch{
                    return "Oopps something went wrong";
                }
            }else{
            return "User Not authenticated";
            }
        }

        #endregion
    }
}