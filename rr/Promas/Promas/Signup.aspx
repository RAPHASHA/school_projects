<%@ Page Title="" Language="C#" MasterPageFile="~/musiccity.Master" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="Promas.Signup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row form-group">
                    <div class="col-md-12 mb-3 mb-md-0">
                        <label class="font-weight-bold">Name</label>
                        <input type="text" id="Name" class="form-control" placeholder="" runat="server">
                    </div>
                    <div class="col-md-12 mb-3 mb-md-0">
                        <label class="font-weight-bold">Surname</label>
                        <input type="text" id="Surname" class="form-control" placeholder="" runat="server">
                    </div>
                    <div class="col-md-12 mb-3 mb-md-0">
                        <label class="font-weight-bold">Email</label>
                        <input type="email" id="email" class="form-control" placeholder="" runat="server">
                    </div>
                    <div class="col-md-12 mb-3 mb-md-0">
                        <label class="font-weight-bold">Password</label>
                        <input type="password" id="Pass" class="form-control" placeholder="" runat="server">
                    </div>
                    <div class="col-md-12 mb-3 mb-md-0">
                        <label class="font-weight-bold">Confirm Password</label>
                        <input type="password" id="ConfPass" class="form-control" placeholder="" runat="server">
                    </div>

            <div class="col-md-12 mb-3 mb-md-0">
                        <label class="font-weight-bold">Confirm Password</label>
                        <input type="password" id="Password1" class="form-control" placeholder="" runat="server">
                    </div>

                </div>
                
                
              

                <div class="row align-items-center justify-content-center">
                    <asp:Button ID="btnReg" runat="server" Text="Register" class="btn btn-primary py-3 px-4" OnClick="btnReg_Click" />
                </div>

</asp:Content>
