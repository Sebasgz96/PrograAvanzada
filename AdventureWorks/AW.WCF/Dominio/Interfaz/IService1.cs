﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace AW.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        [OperationContract]
        Model.Product EncontrarProductoPorNumero(string elNumero);

        [OperationContract]
        IList<Model.Product> ListarTodos();

        [OperationContract]
        IList<Model.Product> BuscarProductoPorRangoDePrecio(decimal elPrecioInferior, decimal elPrecioSuperior);

        /***********************************************************************************************/

        [OperationContract]
        IList<Model.Product> BuscarProductoPorNombre(string elNombre);

        [OperationContract]
        IList<Model.Product> BuscarProductoPorFechaV(DateTime laFecha);

        [OperationContract]
        IList<Model.Product> BuscarProductoPorColor(string elColor);

        [OperationContract]
        IList<Model.Product> BuscarProductoPorNombreSubC(string elNombre);

        [OperationContract]
        IList<Model.Product> BuscarProductoPorNombreC(string elNombre);

        [OperationContract]
        IList<Model.Product> BuscarProductoPorNombreM(string elNombre);

        [OperationContract]
        IList<Model.Product> BuscarProductoPorReview();



        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
