   M S B A M L   `   `   `  ����D  @Documents, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Documents	Documents  5      ;"clr-namespace:Documents.ViewModelsDocuments.ViewModels  5      )    #Documents.Views.DocumentsReportPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:Documents     5      1vm"clr-namespace:Documents.ViewModels     5        N� Title$  DocumentsReportPage��5
       � DataContext 5      7   1Documents.ViewModels.DocumentsReportPageViewModel  5   
   .��5      � ��5   
   �� 5       �� ImageSource$ watermark.png��6    � ColumnDefinitions 5   
   �� 5      $	��230 �6   �� 5       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5   
   �� $��1��6      headerTextStyle#��[  6    .��6I   86Информация за документите на:6h   � 5    
   $��10q�6   $��1��6   $��1��6+    5!      �� 5"      �� 5#       5%      �� 5&      $
��Auto �6    �� 5'      $
��Auto �6    �� 5(      .+�5+      �� $��0��6   $��2��6)   $��0��6=    �� Orientation$ 
Horizontal=�6J   .+�5,      ��   
labelStyle#��[ 6   .��6<   	Име:6B   �� 5-      #��[ 6   ��6<   �� *Name+6W   5.      �� 50      $��0��6   $��2��6)   $��1��6=   $ 
Horizontal=�6J   .+�51      �� #��[ 6   .��6<   Работа:6E   �� 52      #��[ 6   ��6<   �� *Job+6V   53      � 54      $��0��6   $��2��6#   $��2��67   $	��Top=�6D   $
��Left=�6\   .+�56      &   System.Windows.Controls.DataGrid    columnHeaderStyle   ColumnHeaderStyle# [ 6=      AutoGenerateColumns .     RowHeaderWidth$ 0Q�6�   ��6   �� *	Documents+	   Columns	 57      0  *System.Windows.Controls.DataGridTextColumn  58      ,  &System.Windows.Controls.DataGridColumn
   Header$$
 Вид на документа��6-   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6G   �� *DocumentName+  59      $$
 Дата на издаване��6-    6G   �� *CreationDate+  5:      $(
 "Номер на документа��6-    6I   �� *
DocumentId+5<      5=      5>      5?      5@      