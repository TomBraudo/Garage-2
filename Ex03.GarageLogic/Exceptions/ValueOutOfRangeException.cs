using System;
using System.Text;

namespace Ex03.GarageLogic.Exceptions
{
    public class ValueOutOfRangeException : Exception
    {
        private float m_MaxValue;
        private float m_MinValue;
        private string m_ObjectType;

        public ValueOutOfRangeException(string i_ErrorMessage, string i_ObjectType, float i_MaxValue, float i_MinValue) : base(i_ErrorMessage)
        {
            m_MaxValue = i_MaxValue;
            m_MinValue = i_MinValue;
            m_ObjectType = i_ObjectType;
        }

        public override string ToString()
        {
            StringBuilder errorMessageBuilder = new StringBuilder();

            errorMessageBuilder.AppendFormat("Illegal action on a {0}{1}", m_ObjectType, Environment.NewLine);
            errorMessageBuilder.AppendLine(Message);
            errorMessageBuilder.AppendFormat("Legal values are: {0} - {1}", m_MinValue, m_MaxValue);

            return errorMessageBuilder.ToString();
        }
    }
}
