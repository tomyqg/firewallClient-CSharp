   M S B A M L   `   `   `  ����C  ?FireWall, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:FireWallFireWall  5   	       FireWall.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   c _DevExpress.Xpf.Gauges.v15.1, Version=15.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a?dxga4http://schemas.devexpress.com/winfx/2008/xaml/gauges  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   "localclr-namespace:FireWall  5   	   -   5          � 
ResizeMode$  NoResize=�5	   	    � WindowStyle$
 None=�6    � WindowState$ 	Maximized=�62    � WindowStartupLocation$ CenterScreen=�6J   $
��1280��6�   $	��720��6�   ��6o   Z� .��5
      � -   5         �Name$ MainBox��5
       	  white#���   6   .+�5   
   � $��25��6   $	��Top=�6     backgroundbrush#���  63   .+�5      �� -   5         ��Name$ MinimizedButton��5      $�� ��6.   $��0,0,50,0q�69     MainButtonStyle#���  6K   $	��Top=�6u   $��Right=�6�   $��25��6�     MinimizeButtonBrush#���  6�   $��25��6  �� 5      -   5        $ MaximizedButton��5      $�� ��6.   $��Right=�69   $��0,0,25,0q�6U   #���  6g   $	��Top=�6�   $��25��6�     RestoreButtonBrush#���  6�   $��25��6*  �� 5      -   5        $ CloseButton��5      $�� ��6*   $��Right=�65   $��0q�6Q   #���  6\   $��25��6�     CloseButtonBrush#���  6�   $��25��6�   $	��Top=�6�   5      �� 5   
   
�������$��1,1,1,0q�6&   $	��Top=�6@   $��80��6Y   $��0,25,0,0q�6e   ._�5      � -   5        $ NavigationBox��5      $	��Top=�6*   $��80��6C   .+�5      � -   5        $ LeftBox��5      $
��Left=�6(   $	��441��6C   $��0,0,0,0q�6O   #���  6�   .+�5      �� -   5         ��Name$ image��5      $��/image/logo.png��6+   $
��Left=�6D   $��0,0,0,0q�6`   $��80��6q   $	��Top=�6}   $��90��6�   �� 5      -	   5         ��Name$ 	logolabel��5      $'��!工业防火墙配置监控系统��6/   $��74,17,10,16q�6E   
�������$��5,0,0,0q�6m   $��32(�6   $��Center=�6�   5      � 5      -
   5        $ MidBox��5      $��441,0,150,0q�6'   #���  6<    � ColumnDefinitions 5      �� 5      $��60��6+   �� 5      $��60��6+   �� 5      $��60��6+   �� 5      $��60��6+   �� 5      $��60��6+   �� 5      $��60��6+   .+�5      �� -   5        $ 
HomeButton��5      #���  61     HomeButtonBrush#���  6[   6�   �� 5       -   5        $ RealTimeDataButton��5       #���  69     RealTimeDataButtonBrush#���  6c   $��1��6�   �� 5!      -   5        $ 	LogButton��5!      #���  60     LogButtonBrush#���  6[   $��2��6�   �� 5"      -   5        $ StatisticsButton��5"      #���  67    	 StatisticsButtonBrush#��� 	 6b   $��3��6�   �� 5#      -   5        $ UserManagementButton��5#      #���  6;    
 UserManagementButtonBrush#��� 
 6e   $��4��6�   �� 5$      -   5        $ SystemSettingButton��5$      #���  6:     SystemSettingButtonBrush#���  6d   $��5��6�   �� 5%      -   5        $ 	homeimage��5%      $��/image/选中主页.png��6/   $
��Fill=�6H   �� 5&      -   5        $ realtimedataimage��5&      $#��/image/选中实时数据.png��67   $
��Fill=�6R   $��1��6a   $y�	Collapsed=�6q   �� 5'      -   5        $ logimage��5'      $��/image/选中日志.png��6.   $
��Fill=�6G   $��2��6V   $y�	Collapsed=�6f   �� 5(      -   5        $ statisticsimage��5(      $��/image/选中统计.png��65   $
��Fill=�6N   $��3��6]   $y�	Collapsed=�6m   �� 5)      -   5        $ usermanagementimage��5)      $#��/image/选中用户管理.png��69   $
��Fill=�6T   $��4��6c   $y�	Collapsed=�6s   �� 5*      -   5        $ systemsettingimage��5*      $#��/image/选中系统设置.png��68   $
��Fill=�6S   $��5��6b   $y�	Collapsed=�6r   5+      � 5,      -   5        $ RightBox��5,      $��Right=�6)   $	��150��6E   #���  6Q   .+�5-      �� -   5        	 ��Name$
	 Date��5-       $��2016年03月15日��6.   $��	-6,10,0,0q�6A   $
��Wrap=�6T     	FontBrush#���  6h   $��19��6�   $	��Top=�6�   $
��Left=�6�   $	��146��6�   
 �� TextAlignment$
 Center=�6�   $��16(�6�   /  )DevExpress.Xpf.Gauges.DigitalGaugeControl  5.      -   5          Name$
 Time��5.   /      Text$ 22:00:00��6=      SymbolCount$ 8��6M   $��0��6]   $��-23,10,-10,-10q�6m   $��LeftToRight=�6�   #���  5/   &   
�������$��Stretch=�6i   $��Stretch=�6�      TextDirection$ RightToLeft=�6�      Model 50      /  )DevExpress.Xpf.Gauges.DigitalDefaultModel  51         
SymbolView 53      -  'DevExpress.Xpf.Gauges.SevenSegmentsView  54      *  $DevExpress.Xpf.Gauges.SymbolViewBase   Width1  +DevExpress.Xpf.Gauges.SymbolLengthConverter$ 16 65      Presentation 55   "   <  6DevExpress.Xpf.Gauges.DefaultSevenSegmentsPresentation  56   &      
FillActive# �  6L      FillInactive 57   *   �� 58   .    �� Color$ 	#FF616161��6>    �� Opacity$	 0.2Q�6P   5:   '      Options 5<   "   )  #DevExpress.Xpf.Gauges.SymbolOptions  5=   &   5?      5A      5B      5C      5D      � 5E   
   -   5        $ 
ContentBox��5E      $��	0,105,0,0q�6#   5F      5G      