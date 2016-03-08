﻿<%@ Page Title="" Language="C#" MasterPageFile="~/views/layout/Site.Master" AutoEventWireup="true" CodeBehind="FormThemHS.aspx.cs" Inherits="Project.views.FormThemHS" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<%--  --%>
    <div class="table-responsive font_bold form_themmoiHS">
        <form runat="server">
            <table class="table table-condensed">
                <tr>
                    <th colspan="4" class="tilte_themmoiHS">THÊM MỚI HỒ SƠ</th>
                </tr>
                <tr>
                    <td>Cơ quan lưu trữ</td>
                    <td colspan="3">
                        <asp:DropDownList ID="ddl_CQLuuTru" runat="server" Width="100%"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>Phông</td>
                    <td colspan="3">
                        <asp:DropDownList ID="ddl_Phong" runat="server" Width="100%"></asp:DropDownList>
                    </td>
                </tr>

                <tr>
                    <td>Mục lục số</td>
                    <td>
                        <asp:DropDownList ID="ddl_MucLucSo" runat="server" Width="62%"></asp:DropDownList>
                    </td>
                    <td>Hộp số</td>
                    <td>
                        <asp:TextBox ID="txt_HopSo" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>Hồ sơ số</td>
                    <td>
                        <asp:TextBox ID="txt_HSSo" runat="server"></asp:TextBox>
                    </td>
                    <td>Ngôn ngữ</td>
                    <td>
                        <asp:DropDownList ID="ddl_NgonNgu" runat="server"></asp:DropDownList>
                    </td>
                </tr>

                <tr>
                    <td>Ký hiệu thông tin</td>
                    <td>
                        <asp:TextBox ID="txt_KHTT" runat="server"></asp:TextBox>
                    </td>
                    <td></td>
                    <td></td>
                </tr>

                <tr>
                    <td>Tiêu đề hồ sơ</td>
                    <td colspan="3">
                        <asp:TextBox ID="txt_TDHS" runat="server" Width="100%"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>Chú giải</td>
                    <td colspan="3">
                        <asp:TextBox id="txta_ChuGiai" TextMode="multiline" Width="100%" Rows="5" runat="server" />
                    </td>
                </tr>

                <tr>
                    <td>Thời gian bắt đầu</td>
                    <td>
                        <asp:TextBox ID="txt_TGBD" runat="server"></asp:TextBox>
                    </td>
                    <td>Thời gian kết thúc</td>
                    <td>
                        <asp:TextBox ID="txt_TGKT" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Bút tích</td>
                    <td colspan="3">
                        <asp:TextBox ID="txt_Buttich" runat="server" Width="100%"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Số lượng từ</td>
                    <td>
                        <asp:TextBox ID="txt_SoLuongTu" runat="server"></asp:TextBox>
                    </td>
                    <td>Thời hạn bảo quản</td>
                    <td>
                        <asp:DropDownList ID="ddl_TGBaoquan" runat="server" Width="70%"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>Chế độ sử dụng</td>
                    <td>
                        <asp:DropDownList ID="ddl_CDSD" runat="server" Width="62%"></asp:DropDownList>
                    </td>
                    <td>Tình trạng vật lý</td>
                    <td>
                        <asp:DropDownList ID="ddl_TTVL" runat="server" Width="100%"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td colspan="3">
                        <asp:Button ID="btn_themmoi" runat="server" Text="Thêm mới" />
                        <asp:Button ID="btn_huybo" runat="server" Text="Hủy bỏ" />
                        <asp:Button ID="btn_quaylai" runat="server" Text="Quay lại" />
                    </td>
                </tr>
            </table>
        </form>
    </div>
</asp:Content>