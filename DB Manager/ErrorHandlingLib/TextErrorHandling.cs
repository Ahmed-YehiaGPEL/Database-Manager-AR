using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace ErrorHandlingLib
{
    public class TextErrorHandling
    {
       // private SortedDictionary<int, string> _errorHandlerDictionary = new SortedDictionary<int, string>();
        private string[] _errorHandlerDictionary = new string[] { };
        /// <summary>
        /// Represent the error cases needed while giving error
        /// </summary>
        public enum ErrorCases
        {
            errorCase1,
            errorCase2
        }
        private void loadErrorData(XDocument errorDocumentV, string _descendantNameV, string _elementNameV)
        {
            int _intCounter = 0;
            var errorData = from errorFile in errorDocumentV.Descendants(_descendantNameV) // linq reader
                            select new
                            {
                                Error = errorFile.Element(_elementNameV).Value,
                            };

            foreach (var error in errorData) //iteration
            {
                _errorHandlerDictionary[_intCounter] = error.ToString();

            }
            

        }
        public void presentErrorMsg(TextBox controlToPresent, ErrorProvider eProvider, XDocument errorDocument, string _descendantName,string _elementName,int _indexOfError)
        {
            loadErrorData(errorDocument, _descendantName, _elementName);
            eProvider.SetError(controlToPresent, _errorHandlerDictionary[_indexOfError]);
        }
        public void presentErrorMsg(TextBox controlToPresent, TextBox controlToCompareDataWith, ErrorProvider eProvider, XDocument errorDocument, string _descendantName,string _elementName,int _indexOfError)
        {
            loadErrorData(errorDocument, _descendantName, _elementName);
            while(controlToPresent.Text != controlToCompareDataWith.Text)
            {
                eProvider.SetError(controlToCompareDataWith, _errorHandlerDictionary[_indexOfError]);
            }
        }
        public void clearError(TextBox controlToClear, ErrorProvider eProvider)
        {
            eProvider.SetError(controlToClear, null);
        }

    }
}
