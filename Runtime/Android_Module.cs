#region Access
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#endregion
namespace Architecture.Android
{
    public static class Key
    {
        // public const string _   = KeyData._;
        public static string Initialize = "";
        public static string AddClass = ""; //añade al dicionario AndroidJavaClass una clase con el string proporcionado
        public static string AddObject = ""; //añade al dicionario AndroidJavaObject un obj con el string proporcionado
        public static string Cast = ""; //añade al dicionario AndroidJavaObject un obj con el string proporcionado
    }
    public static class Import
    {
        //public const string _ = _;
    }
    public sealed partial class Android_Module : Module
    {
        #region References
        //[Header("Applications")]
        //[SerializeField] public ApplicationBase interface_Android;
        #endregion
        #region Reactions ( On___ )
        // Contenedor de toda las reacciones del Android
        protected override void OnSubscription(bool condition)
        {
            //
        }
        #endregion
        #region Methods
        // Contenedor de toda la logica del Android
        #endregion
        #region Request ( Coroutines )
        // Contenedor de toda la Esperas de corutinas del Android
        #endregion
        #region Task ( async )
        // Contenedor de toda la Esperas asincronas del Android
        #endregion
    }
}