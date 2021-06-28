// -----------------------------------------------------------------------
//  <copyright project="CAS.USPS"
//             assembly="libcasusps"
//             solution="CAS.USPS"
//             company="Chris Adams Studios">
//      Copyright (c) 1996+. All rights reserved.
//  </copyright>
//  <author id="chris@chrisadams-studios.com">Chris Adams</author>
//  <summary></summary>
// -----------------------------------------------------------------------

#region References

using System;
using System.Runtime.Serialization;

#endregion

namespace CAS.USPS.Exceptions
{
    [Serializable]
    public class UspsException : ApplicationException
    {
        public UspsException()
        {
        }

        public UspsException(string message)
            : base(message)
        {
        }

        public UspsException(Exception ex) :
            base(ex.Message)
        {
        }

        protected UspsException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}