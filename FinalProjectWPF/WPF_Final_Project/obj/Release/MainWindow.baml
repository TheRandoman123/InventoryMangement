   M S B A M L   `   `   `  ���� L  HWPF_Final_Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:WPF_Final_Project.ViewModelsWPF_Final_Project.ViewModels  A%clr-namespace:WPF_Final_Project.ViewsWPF_Final_Project.Views  "    WPF_Final_Project.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     A
viewmodels*clr-namespace:WPF_Final_Project.ViewModels     7views%clr-namespace:WPF_Final_Project.Views     $��18(�$��Arial)�  � Title$	  BMC��$	��819��$
��1463�� � WindowState$ 	Maximized=� � 	Resources  �� DataType5   /WPF_Final_Project.ViewModels.InventoryViewModel'   !WPF_Final_Project.Views.Inventory � DataContext1   +WPF_Final_Project.ViewModels.UsersViewModel#   WPF_Final_Project.Views.Users3  -WPF_Final_Project.ViewModels.ReportsViewModel%   WPF_Final_Project.Views.Reports6  0WPF_Final_Project.ViewModels.TagCreatorViewModel(   "WPF_Final_Project.Views.TagCreator=	  7WPF_Final_Project.ViewModels.EmergencyRegisterViewModel/
   )WPF_Final_Project.Views.EmergencyRegister2  ,WPF_Final_Project.ViewModels.AuditsViewModel$   WPF_Final_Project.Views.Audits��%�  (��       *, +)(�� 1     *, +)(�� ^     *, +)(�� �     *, +)(�� �     *,	 +)(�� �     *, +)�� InventoryTemplate��"  .R�   �� �� UsersTemplate��"  .R�   �� �� ReportsTemplate��"  .R�   �� �� TagCreatorTemplate��"  .R�   �� �� EmergencyRegisterTemplate��" 	 .R�
   �� �� AuditsTemplate��"  .R�   �� .��� -    �Name$
 Grid�� � ColumnDefinitions �� $	��232 ���  � RowDefinitions �� $��60 ��� $��60 ��� $��60 ��� $��60 ��� $��60 ��� $��60 ��� $��60 ��� $��* �.+��� $
��Auto��$
��Auto��$��0��$��0��$��2������  �� Color �� 	 �� A$		 255��
 �� R$
 19�� �� G$ 36�� �� B$ 45���� -    ��Name$ InventorySpace��$
��Auto��$
��Auto��$��0��$��1������  �� $		 255��$
 23��$ 42��$ 51���� -   $ 	UserSpace��$
��Auto��$
��Auto��$��0��$��2������  �� $		 255��$
 23��$ 42��$ 51���� -   $ ReportSpace��$
��Auto��$
��Auto��$��0��$��3������  �� $		 255��$
 23��$ 42��$ 51���� -   $ TagCreatorSpace��$
��Auto��$
��Auto��$��0��$��4������  �� $		 255��$
 23��$ 42��$ 51���� -   $ EmergencyRegisterSpace��$
��Auto��$
��Auto��$��0��$��5������  �� $		 255��$
 23��$ 42��$ 51���� -   $ 
AuditSpace��$
��Auto��$
��Auto��$��0��$��6������  �� $		 255��$
 23��$ 42��$ 51���� -   $ UnusedSpace��$
��Auto��$
��Auto��$��0��$��7������  �� $		 255��$
 23��$ 42��$ 51���� $
��Auto��$
��Auto��$��1��$��1��$��7������  �� $		 255��$
 32��$ 49��$ 58���� $��0��$��0��$��45,18,129,18q�$	��BMC�����#16BF83$��25(��� -	    ��Name$ InventoryLabel��$��0��$��1��$��45,25,131,20q�$��	Inventory�����#16BF83$��13(��� -
   $ 	UserLabel��$��0��$��2��$��45,21,131,23q�$��Users�����#16BF83$��13(��� -   $ ReportLabel��$��0��$��3��$��45,21,131,23q�$��Reports�����#16BF83$��13(��� -   $ TagCreatorLabel��$��0��$��4��$��45,21,115,23q�$��Tag Creator�����#16BF83$��13(��� -   $ EmergencyRegisterLabel��$��0��$��5��$��45,21,65,23q�$��Emergency Register�����#16BF83$��13(��� -   $ 
AuditLabel��$��0��$��6��$��45,21,65,23q�$��Audits�����#16BF83$��13(�]� $��1��$��1��$��7�� � LayoutTransform ��  �� CenterX$ 0Q� �� CenterY$ 0Q� �� ScaleX ��  �� ElementName$ uiScaleSlider�� �� Path$ Value� �� ScaleY �� $ uiScaleSlider��$ Value�.+��� ���� �� -    ��Name$ uiScaleSlider�� � ToolTip$% Determines the UI scale factor.�� � Minimum$	 0.1Q� � Maximum$ 4Q�$��1��$��Bottom=�$��7��