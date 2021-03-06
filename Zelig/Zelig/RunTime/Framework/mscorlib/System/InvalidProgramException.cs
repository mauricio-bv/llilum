// ==++==
// 
//   Copyright (c) Microsoft Corporation.  All rights reserved.
// 
// ==--==
/*=============================================================================
**
** Class: InvalidProgramException
**
**
** Purpose: The exception class for programs with invalid IL or bad metadata.
**
**
=============================================================================*/

namespace System
{
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public sealed class InvalidProgramException : SystemException
    {
        public InvalidProgramException() : base( Environment.GetResourceString( "InvalidProgram_Default" ) )
        {
////        SetErrorCode( __HResults.COR_E_INVALIDPROGRAM );
        }

        public InvalidProgramException( String message ) : base( message )
        {
////        SetErrorCode( __HResults.COR_E_INVALIDPROGRAM );
        }

        public InvalidProgramException( String message, Exception inner ) : base( message, inner )
        {
////        SetErrorCode( __HResults.COR_E_INVALIDPROGRAM );
        }

////    internal InvalidProgramException( SerializationInfo info    ,
////                                      StreamingContext  context ) : base( info, context )
////    {
////    }
    }
}
