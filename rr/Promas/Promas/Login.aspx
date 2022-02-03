<%@ Page Title="" Language="C#" MasterPageFile="~/musiccity.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Promas.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      
     	<div style="background-image: url(images/wp3413575.jpg);">
		   		<div class="overlay-gradient"></div>
		   		<div class="container">
		   			<div class="row">
			   			<div class="col-md-8 col-md-offset-2 text-center js-fullheight slider-text">
			   				<div class="slider-text-inner">
			   					  <div class="megamenu-back">
           
        <div class= "loginbox">

           
       
       <div >
         
			<h2 align:"Left" >User Login</h2>
			
			<label class="labelemail" >Username:</label>
			<input type="text" id="username" class="txtpass" placeholder="" runat="server">
			<br/>
			<br/>
			<label class="labelpass">Password:</label>
           	<br/>
			<input type="password" id="passw" class="txtpass" placeholder="" runat="server">
			<br/>
			
			
			
			
        
           <asp:Button ID="btnsubmit"  cssclass="btnsumit" runat="server" Text="Submit" />
			<br/>
			

            <ul>
                <li>
				<%--<a href="register.html" class="labelemail">Sign up if you don't have an account</a>--%>
			</li>
            </ul>
			 

			</div>
    </div>
     </div>
			   				</div>
			   			</div>
			   		</div>
		   		</div>
		   	</div>	 
</asp:Content>
