using System.Collections.Generic;
using System.Linq;

namespace Amazing
{
    public  class AmazingResult
    {
        private static readonly AmazingResult _success = new AmazingResult { Succeeded = true };
        private List<AmazingError> _errors = new List<AmazingError>(); 
        public bool Succeeded { get; protected set; } 
        public IEnumerable<AmazingError> Errors => _errors; 
        public static AmazingResult Success => _success; 
        public static AmazingResult Failed(params AmazingError[] errors)
        {
            var result = new AmazingResult { Succeeded = false };
            if (errors != null)
            {
                result._errors.AddRange(errors);
            }
            return result;
        } 
        public override string ToString()
        {
            return Succeeded ?
                   "Succeeded" :
                   string.Format("{0} : {1}", "Failed", string.Join(",", Errors.Select(x => x.Code).ToList()));
        }
    }
}
