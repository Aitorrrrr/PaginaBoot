Imports System.Web.Script.Serialization

Public Class MontaMenu
    Sub New()
        Dim jsonRecibido As String = "{
  ""Logistica"": {
    ""Ventas"": {
      ""1"": ""Pedidos"",
      ""2"": ""Albaranes"",
      ""3"": ""Facturas""
    },
    ""Compras"": {
      ""1"": ""Pedidos"",
      ""2"": ""Albaranes"",
      ""3"": ""Facturas""
    }
  },
  ""Ventas"": {
    ""Operaciones"": {
      ""1"": ""Pedidos"",
      ""2"": ""Albaranes"",
      ""3"": ""Facturas""
    },
    ""Procesos"": {
      ""1"": ""Autoalbaranar"",
      ""2"": ""Autofactura""
    }
  },
  ""Informes"": {
    ""Ventas"": {
      ""1"": ""Clientes por localidad"",
      ""2"": ""Resumen IVA"",
      ""3"": ""ABC producto"",
      ""4"": ""ABC cliente""
    }
  }
}"

        Dim parteArriba As String
        parteArriba = "<div class=""page-wrapper chiller-theme toggled"">
                        <a id=""show-sidebar"" class=""btn btn-sm btn-dark"" href=""#"">
                            <i class=""fas fa-bars""></i>
                        </a>
                        <nav id=""sidebar"" class=""sidebar-wrapper"" >
                            <div class=""sidebar-content"">
                                <div class=""sidebar-brand"">
                                    <a href=""#"">Sim Levante</a>
                                    <div id=""close-sidebar"">
                                        <i class=""fas fa-times""></i>
                                    </div>
                                </div>"

        Dim parteAbajo As String
        parteAbajo = "      </div>
                            <div class=""sidebar-footer"">
                                <a href=""#"">
                                    <i class=""fa fa-bell""></i>
                                    <span class=""badge badge-pill badge-warning notification"">3</span>
                                </a>
                                <a href=""#"">
                                    <i class=""fa fa-cog""></i>
                                    <span class=""badge-sonar""></span>
                                </a>
                            </div>
                        </nav>
                    </div>"


        Dim jss As New JavaScriptSerializer
        Dim diccionario As Dictionary(Of String, String) = jss.Deserialize(Of Dictionary(Of String, String))(jsonRecibido)


        Dim nodosGrandes = diccionario.Count

        For cont = 0 To diccionario.Count - 1

        Next
    End Sub
End Class
