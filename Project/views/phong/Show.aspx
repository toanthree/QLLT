﻿<%@ Page Title="" Language="C#" MasterPageFile="~/views/layout/Site.Master" AutoEventWireup="true" CodeBehind="show.aspx.cs" Inherits="Project.views.phong.Show" %>

<%@ Register TagPrefix="uc" TagName="sidebarQLDM" Src="~/views/partials/sidebarQLDanhmuc.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <div class="row">

        <uc:sidebarQLDM runat="server" />

        <div class="col-sm-9 div_content_QLphong">
            <div class="row nav_bar header_padding text-left">Quản lý Phông lưu trữ</div>
            <br />
            <asp:Panel ID="div_alert" runat="server">
                <asp:Label ID="lbl_ShowInfo" runat="server" ForeColor="#009933"></asp:Label>
            </asp:Panel>
            <asp:Button ID="btn_show_insert" runat="server" CssClass="btn btn-primary font_12 font_bold" OnClick="btn_show_insert_Click" Text="Thêm mới" />
            <div class="div_insert table-responsive" id="div_insert" runat="server">
                <table class="table table-condensed">
                    <tr>
                        <th colspan="4" class=" text-center font_18">THÊM MỚI PHÔNG</th>
                    </tr>
                    <tr>
                        <td>
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td ><label for="txt_TenPhong" class="form-control-static"> Phông: </label></td>
                        <td colspan="3">
                            <asp:TextBox ID="txt_TenPhong" class="form-control" runat="server" Width="100%"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td><label for="txta_GhiChu" class="form-control-static"> Ghi chú: </label></td>
                        <td colspan="3">
                            <asp:TextBox ID="txta_GhiChu" class="form-control" TextMode="MultiLine" Width="100%" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td colspan="3">
                            <input type="hidden" runat="server" id="hidden_id" />
                            <asp:Button ID="btn_sua" class="btn btn-primary font_12 font_bold" runat="server" Text="Sửa" />
                            <asp:Button ID="btn_themmoi" class="btn btn-primary font_12 font_bold" runat="server" Text="Thêm mới" OnClick="btn_themmoi_Click" />
                            <asp:Button ID="btn_huybo" class="btn btn-danger font_12 font_bold" runat="server" Text="Hủy bỏ" OnClick="btn_huybo_Click" />
                            <asp:Button ID="btn_quaylai" class="btn btn-warning font_12 font_bold" runat="server" Text="Ẩn" OnClick="btn_quaylai_Click" />
                        </td>
                    </tr>
                </table>
            </div>
            <div class="table-responsive font_bold" style="padding: 6px;">
                <asp:ListView ID="lst_Phong" runat="server" ItemPlaceholderID="place_holder_phong" OnPagePropertiesChanging="lst_Phong_PagePropertiesChanging">
                    <LayoutTemplate>
                        <table class="table table-bordered text-center">
                            <tr class="font_14">
                                <td>STT</td>
                                <td>Mã Phông</td>
                                <td>Tên Phông lưu trữ</td>
                                <td>Ghi chú</td>
                                <td>Thao tác</td>
                            </tr>
                            <asp:PlaceHolder runat="server" ID="place_holder_phong" />
                        </table>
                    </LayoutTemplate>
                    <ItemTemplate>
                        <tr>
                            <td><% Response.Write(i); IncreaseI();%></td>
                            <td>
                                <%#Eval("MaPhong") %>
                            </td>
                            <td><%#Eval("TenPhong") %></td>
                            <td><%#Eval("GhiChu") %></td>
                            <td>
                                <asp:LinkButton ID="btn_edit_phong" CommandName='<%#Eval("MaPhong") %>' OnClick="btn_edit_phong_Click" CssClass="btn btn-info btn-xs" runat="server">
                                    <span class="glyphicon glyphicon-edit"></span> &nbsp;Sửa

                                </asp:LinkButton>
                                <asp:LinkButton ID="btn_remove_phong" CommandName='<%#Eval("MaPhong") %>' OnClientClick="return confirm('Bạn có chắc chắn muốn xóa?')" OnClick="btn_remove_phong_Click" CssClass="btn btn-info btn-xs" runat="server">
                                     <span class="glyphicon glyphicon-remove"></span> &nbsp;Xóa
                                </asp:LinkButton>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:ListView>

                <div class="text-center">
                    <asp:DataPager ID="Pager_Phong" runat="server" PagedControlID="lst_Phong" PageSize="5">
                        <Fields>
                            <asp:NextPreviousPagerField ButtonType="Link" ShowFirstPageButton="false" ShowPreviousPageButton="true" PreviousPageText="Trước"
                                ShowNextPageButton="false" />
                            <asp:NumericPagerField ButtonType="Link" />
                            <asp:NextPreviousPagerField ButtonType="Link" ShowNextPageButton="true" ShowLastPageButton="false" ShowPreviousPageButton="false" NextPageText="Sau" />
                        </Fields>
                    </asp:DataPager>
                </div>
            </div>

        </div>
    </div>
</asp:Content>
