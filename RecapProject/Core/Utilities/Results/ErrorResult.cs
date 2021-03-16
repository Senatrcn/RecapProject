using System;
using System.Collections.Generic;
using System.Text;

namespace RecapProject.Core.Utilities.Results
{
    public class ErrorResult: Result
    {
        public ErrorResult(string message):base(false,message)
        {

        }
        public ErrorResult():base(false)
        {

        }
    }
}
