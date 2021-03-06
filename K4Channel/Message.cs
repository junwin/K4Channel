﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace K4Channel
{
    public class MessageHEader : IMessageHeader
    {
        private string clientId;

        public string ClientID
        {
            get { return clientId; }
            set { clientId = value; }
        }
        private string clientSubId;

        public string ClientSubID
        {
            get { return clientSubId; }
            set { clientSubId = value; }
        }
        private string correlationId;

        public string CorrelationID
        {
            get { return correlationId; }
            set { correlationId = value; }
        }
    }
    /// <summary>
    /// Data implimentation of a kaiTrade message - this can contain FIX and FIXML data 
    /// </summary>
    //[DataContract]
    //[JsonObject(MemberSerialization.OptIn)]
    //[global::System.Data.Linq.Mapping.TableAttribute(Name = "dbo.Message")]
    public class Message : IMessage, IMessageHeader
    {
        /// <summary>
        /// unique ID for this message
        /// </summary>
        private string m_Identity;
        private long m_AppSpecific;
        private int m_AppState;
        private string m_AppType;
        private string m_ClientID = "";
        private string m_ClientSubID = "";
        private string m_CorrelationID = "";
        private string m_CreationTime;
        private string m_Data;
        private string m_Format;
        private string m_Label;
        private string m_Tag = "";
        private string m_TargetID = "";
        private string m_TargetSubID = "";
        private string m_UserID;
        private string m_VenueCode;

        public Message()
        {
            m_Identity = System.Guid.NewGuid().ToString();
        }


        /// <summary>
        /// unique ID for this message
        /// </summary>
        //[DataMember]
        //[JsonProperty]
        //[global::System.Data.Linq.Mapping.ColumnAttribute(Name = "[Identity]", Storage = "m_Identity", DbType = "NVarChar(36) NOT NULL", CanBeNull = false, IsPrimaryKey = true)]
        public string Identity
        {
            get
            {
                return m_Identity;
            }
            set
            {
                m_Identity = value;
            }
        }


        //[DataMember]
        //[JsonProperty]
        //[System.Data.Linq.Mapping.Column]
        public long AppSpecific
        {
            get
            {
                return m_AppSpecific;
            }
            set
            {
                m_AppSpecific = value;
            }
        }

        //[DataMember]
        //[JsonProperty]
        //[System.Data.Linq.Mapping.Column]
        public int AppState
        {
            get
            {
                return m_AppState;
            }
            set
            {
                m_AppState = value;
            }
        }

        //[DataMember]
        //[JsonProperty]
        //[System.Data.Linq.Mapping.Column(DbType = "NVarChar(256)")]
        public string AppType
        {
            get
            {
                return m_AppType;
            }
            set
            {
                m_AppType = value;
            }
        }

        //[DataMember]
        //[JsonProperty]
        //[System.Data.Linq.Mapping.Column(DbType = "NVarChar(256)")]
        public string ClientID
        {
            get
            {
                return m_ClientID;
            }
            set
            {
                m_ClientID = value;
            }
        }

        //[DataMember]
        //[JsonProperty]
        //[System.Data.Linq.Mapping.Column(DbType = "NVarChar(256)")]
        public string ClientSubID
        {
            get
            {
                return m_ClientSubID;
            }
            set
            {
                m_ClientSubID = value;
            }
        }

        //[DataMember]
        //[JsonProperty]
        //[System.Data.Linq.Mapping.Column(DbType = "NVarChar(256)")]
        public string CorrelationID
        {
            get
            {
                return m_CorrelationID;
            }
            set
            {
                m_CorrelationID = value;
            }
        }

        //[DataMember]
        //[JsonProperty]
        //[System.Data.Linq.Mapping.Column(DbType = "NVarChar(256)")]
        public string CreationTime
        {
            get
            {
                return m_CreationTime;
            }
            set
            {
                m_CreationTime = value;
            }
        }

        //[DataMember]
        //[JsonProperty]
        //[System.Data.Linq.Mapping.Column(DbType = "NVarChar(4000)")]
        public string Data
        {
            get
            {
                return m_Data;
            }
            set
            {
                m_Data = value;
            }
        }

        //[DataMember]
        //[JsonProperty]
        //[System.Data.Linq.Mapping.Column(DbType = "NVarChar(256)")]
        public string Format
        {
            get
            {
                return m_Format;
            }
            set
            {
                m_Format = value;
            }
        }

        //[DataMember]
        //[JsonProperty]
        //[System.Data.Linq.Mapping.Column(DbType = "NVarChar(256)")]
        public string Label
        {
            get
            {
                return m_Label;
            }
            set
            {
                m_Label = value;
            }
        }

        //[DataMember]
        //[JsonProperty]
        //[System.Data.Linq.Mapping.Column(DbType = "NVarChar(512)")]
        public string Tag
        {
            get
            {
                return m_Tag;
            }
            set
            {
                m_Tag = value;
            }
        }

        //[DataMember]
        //[JsonProperty]
        //[System.Data.Linq.Mapping.Column(DbType = "NVarChar(256)")]
        public string TargetID
        {
            get
            {
                return m_TargetID;
            }
            set
            {
                m_TargetID = value;
            }
        }

        //[DataMember]
        //[JsonProperty]
        //[System.Data.Linq.Mapping.Column(DbType = "NVarChar(256)")]
        public string TargetSubID
        {
            get
            {
                return m_TargetSubID;
            }
            set
            {
                m_TargetSubID = value;
            }
        }

        //[DataMember]
        //[JsonProperty]
        //[System.Data.Linq.Mapping.Column(DbType = "NVarChar(256)")]
        public string UserID
        {
            get
            {
                return m_UserID;
            }
            set
            {
                m_UserID = value;
            }
        }

        //[DataMember]
        //[JsonProperty]
        //[System.Data.Linq.Mapping.Column(DbType = "NVarChar(256)")]
        public string VenueCode
        {
            get
            {
                return m_VenueCode;
            }
            set
            {
                m_VenueCode = value;
            }
        }
    }
}
