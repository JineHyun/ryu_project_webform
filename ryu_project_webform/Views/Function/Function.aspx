<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Function.aspx.cs" Inherits="ryu_project_webform.Views.Function.Function" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript">
        $(function () {
            $("#divMain").find("input[type=text]").keyup(function () {
                $(this).val($(this).val().replace(/[^0-9]/g, ""));
            });

            var getVal = $("#<%=hidDictionary.ClientID %>").val();
            $("#txtDictionary").val(getVal);

            var obj = {
                "data": [{
                    "id": 1
                    , "name": "홍길동"
                }
                    , {
                    "id": 2
                    , "name": "유관순"
                }]
            };

            //ajax
            $.ajax({
                type: "POST",
                data: JSON.stringify(obj.data[0]),
                url: "Function.aspx/functionAjax",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    var returnValue = JSON.parse(response.d);

                }, beforeSend: function () {

                }, complete: function () {

                },
                error: function (request, status, error) {
                    alert("code:" + request.status + "\n" + "message:" + request.responseText + "\n" + "error:" + error);
                }
            });
        });
    </script>
    <div id="divMain">
        <h2>숫자만 입력</h2>
        <input type="text" id="txtNumber" />
        <h2>Dictionary 키 값 가져오기</h2>
        <input type="text" id="txtDictionary" />
        <h2>ajax</h2>
        <input type="text" id="txtAjax" />
        <asp:HiddenField ID="hidDictionary" runat="server"/>
    </div>
</asp:Content>
