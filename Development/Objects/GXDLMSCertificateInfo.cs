//
// --------------------------------------------------------------------------
//  Gurux Ltd
// 
//
//
// Filename:        $HeadURL$
//
// Version:         $Revision$,
//                  $Date$
//                  $Author$
//
// Copyright (c) Gurux Ltd
//
//---------------------------------------------------------------------------
//
//  DESCRIPTION
//
// This file is a part of Gurux Device Framework.
//
// Gurux Device Framework is Open Source software; you can redistribute it
// and/or modify it under the terms of the GNU General Public License 
// as published by the Free Software Foundation; version 2 of the License.
// Gurux Device Framework is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of 
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. 
// See the GNU General Public License for more details.
//
// More information of Gurux products: http://www.gurux.org
//
// This code is licensed under the GNU General Public License v2. 
// Full text may be retrieved at http://www.gnu.org/licenses/gpl-2.0.txt
//---------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Gurux.DLMS.ManufacturerSettings;
using Gurux.DLMS.Internal;
using Gurux.DLMS.Objects.Enums;
using Gurux.DLMS.Enums;

namespace Gurux.DLMS.Objects
{
    /// <summary>
    /// Certificate info.
    /// </summary>
    public class GXDLMSCertificateInfo
    {
        /// <summary>
        /// Used certificate entity.
        /// </summary>
        public CertificateEntity Entity
        {
            get;
            set;
        }

        /// <summary>
        /// Used certificate type.
        /// </summary>
        public CertificateType Type
        {
            get;
            set;
        }

        /// <summary>
        /// Certificate serial number.
        /// </summary>
        public string SerialNumber
        {
            get;
            set;
        }

        /// <summary>
        /// Certificate issuer.
        /// </summary>
        public string Issuer
        {
            get;
            set;
        }

        /// <summary>
        /// Certificate subject.
        /// </summary>
        public string Subject
        {
            get;
            set;
        }

        /// <summary>
        /// Certificate subject alt name.
        /// </summary>
        public string SubjectAltName
        {
            get;
            set;
        }
    }
}