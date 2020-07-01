USE [AGMPOP]
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (1, N'administration', N'Administration', NULL, NULL, 1, 1, N'/menu/administration', N'fad fa-user-shield', NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (2, N'cycles', N'Cycles', NULL, NULL, 2, 1, N'/menu/cycles', N'fas fa-recycle', NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (3, N'report', N'Reports', NULL, NULL, 3, 1, N'/menu/reports', N'fa fa-chart-line', NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (4, N'actions', N'Actions', NULL, NULL, 4, 1, N'/menu/actions', N'fa fa-mobile', NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (5, N'usermanagement-index', N'User Management', NULL, 1, 1, 1, N'/usermanagement', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (6, N'rolemanagement-index', N'Role Management', NULL, 1, 2, 1, N'/rolemanagement', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (7, N'jobmanagement-index', N'Job Management', NULL, 1, 3, 1, N'/jobmanagement', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (8, N'territory-index', N'Territories', NULL, 1, 4, 1, N'/territory', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (9, N'department-index', N'Departments', NULL, 1, 5, 1, N'/department', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (10, N'product-index', N'Products', NULL, 1, 6, 1, N'/product', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (11, N'inventory-index', N'Inventory', NULL, 1, 7, 1, N'/inventory', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (12, N'cycles-list', N'Cycles List', NULL, 2, 1, 1, N'/cycles/list', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (13, N'cycles-createcycle', N'Create Cycle', NULL, 2, 2, 2, N'/cycles/createcycle', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (14, N'requests-requestsinbox', N'Requests Inbox', NULL, 2, 7, 1, N'/requests/requestsinbox', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (15, N'transaction-newtransaction', N'New Transaction', NULL, 2, 8, 1, N'/transaction/newtransaction', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (16, N'transaction-canceltransaction', N'Cancel Transaction', NULL, 2, 9, 1, N'/transaction/canceltransaction', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (17, N'requests-index', N'My Requests', NULL, 2, 10, 1, N'/requests', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (18, N'report-cycleindex', N'Cycles', NULL, 3, 1, 1, N'/report/cycleindex', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (19, N'report-transactionindex', N'Transactions', NULL, 3, 2, 1, N'/report/transactionindex', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (20, N'report-stockreportindex', N'Inventory', NULL, 3, 3, 1, N'/report/stockreportindex', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (22, N'cycleactions-cycleindex', N'My Cycles', NULL, 4, 1, 1, N'/cycleactions/cycleindex', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (23, N'cycleactions-notifications', N'Notifications', NULL, 4, 2, 1, N'/cycleactions/notifications', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (24, N'usermanagement-_userlist', N'Users List', NULL, 5, 1, 2, N'/usermanagement/_userlist', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (25, N'usermanagement-createuser', N'Add User', NULL, 5, 2, 2, N'/usermanagement/createuser', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (26, N'usermanagement-updateuser', N'Update User', NULL, 5, 3, 2, N'/usermanagement/updateuser', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (27, N'usermanagement-deactivateuser', N'Deactivate User', NULL, 5, 4, 2, N'/usermanamgent/deactivateuser', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (28, N'usermanagement-activateuser', N'Activate User', NULL, 5, 5, 2, N'/usermanagement/activateuser', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (29, N'usermanagement-importuser', N'Upload Users', NULL, 5, 6, 2, N'/usermanagement/importusers', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (30, N'usermanagement-exportusers', N'Export Users', NULL, 5, 7, 2, N'/usermanagement/exportusers', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (31, N'usermanagement-resetpassord', N'Reset Password', NULL, 5, 8, 2, N'/usermanagement/resetpassword', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (32, N'rolemanagement-_rolelist', N'Roles List', NULL, 6, 1, 2, N'/rolemanagement/_rolelist', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (33, N'rolemanagement-createrole', N'Add Role', NULL, 6, 2, 2, N'/rolemanagement/createrole', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (34, N'rolemanagement-updaterole', N'Update Role', NULL, 6, 3, 2, N'/rolemanagement/updaterole', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (35, N'rolemanagement-deleterole', N'Delete Role', NULL, 6, 4, 2, N'/rolemanagement/deleterole', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (36, N'jobmanagement-_jobtitlelist', N'Job Titles List', NULL, 7, 1, 2, N'/jobmanagement/_jobtitlelist', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (37, N'jobmanagement-addjob', N'Add Job Title', NULL, 7, 2, 2, N'/jobmanagement/addjob', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (38, N'jobmanagement-editjob', N'Update Job Title', NULL, 7, 3, 2, N'/jobmanagement/editjob', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (39, N'jobmanagement-deletejob', N'Delete Job Title', NULL, 7, 4, 2, N'/jobmanagement/deletejob', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (40, N'territory-partialterritories', N'Territories List', NULL, 8, 1, 2, N'/territory/partialterritories
', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (41, N'territory-create', N'Add Territory', NULL, 8, 2, 2, N'/territory/create', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (42, N'territory-edit', N'Rename Territory', NULL, 8, 3, 2, N'/territory/edit', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (43, N'territory-delete', N'Delete Territory', NULL, 8, 4, 2, N'/territory/delete', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (44, N'territory-exportterritories', N'Export Territories', NULL, 8, 5, 2, N'/territory/exportterritories', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (45, N'territory-importpage', N'Upload Territories', NULL, 8, 6, 2, N'/territory/importpage', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (46, N'department-_departmentlist', N'Departments List', NULL, 9, 1, 2, N'/department/_departmentlist', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (47, N'department-adddept', N'Add Department', NULL, 9, 2, 2, N'/department/adddept', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (48, N'department-editdept', N'Upload Department', NULL, 9, 3, 2, N'/department/editdept', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (49, N'department-deactivatedepartment', N'Deactivate Department', NULL, 9, 4, 2, N'/department/deactivatedepartment', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (50, N'department-activatedepartment', N'Activate Department', NULL, 9, 5, 2, N'/department/activatedepartment', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (51, N'product-search', N'Products List', NULL, 10, 1, 2, N'/product/search', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (52, N'product-details', N'Product Details', NULL, 10, 2, 2, N'/product/details', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (53, N'product-create', N'Add Product', NULL, 10, 3, 2, N'/product/create', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (54, N'product-edit', N'Update Product', NULL, 10, 4, 2, N'/product/edit', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (55, N'product-deactivate', N'Deactivate Product', NULL, 10, 5, 2, N'/product/deactivate', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (56, N'product-activate', N'Activate Product', NULL, 10, 6, 2, N'/product/activate', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (57, N'product-exportproduct', N'Export Products', NULL, 10, 7, 2, N'/product/exportproduct', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (58, N'inventory-search', N'View Inventory', NULL, 11, 1, 2, N'/inventory/search', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (59, N'inventory-editquantity', N'Edit Quantity', NULL, 11, 2, 2, N'/inventory/editquantity', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (60, N'invenory-exportinventory', N'Export Inventory', NULL, 11, 3, 2, N'/inventory/exportinventory', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (61, N'inventory-transactions', N'Product Transactions', NULL, 11, 4, 2, N'/inventory/transactions', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (62, N'inventory-transactionproductdetails', N'View', NULL, 61, 1, 2, N'/inventory/transactionproductdetails', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (63, N'inventory-exporttransactioninventory', N'Export', NULL, 61, 2, 2, N'/inventory/exporttransactioninventory', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (64, N'cycles-updatecycle', N'Update Cycle', NULL, 2, 3, 2, N'/cycles/updatecycle', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (65, N'cycles-cycledetails', N'Cycle Details', NULL, 2, 4, 2, N'/cycles/cycledetails', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (66, N'cycles-deactivate', N'Deactivate Cycle', NULL, 2, 5, 2, N'/cycles/deactivate', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (67, N'cycles-activate', N'Activate Cycle', NULL, 2, 6, 2, N'/cycles/activate', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (68, N'transaction-_transactiondetails', N'Transaction Details', NULL, 2, 12, 2, N'/transaction/_transactiondetails', NULL, 1)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (69, N'requests-acceptrequest', N'Accept Requests', NULL, 2, 13, 2, N'/requests/acceptrequest', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (70, N'report-exporttransaction', N'Export Transactions Report', NULL, 3, 5, 2, N'/report/exporttransaction', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (71, N'report-exportcycelreport', N'Export Cycles Report', NULL, 3, 6, 2, N'/report/exportcycelreport', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (72, N'inventory-exportinventory', N'Export Stock Report', NULL, 3, 7, 2, N'/inventory/exportinventory', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (73, N'cycleactions-cycletransaction', N'My Transactions', NULL, 4, 3, 2, N'/cycleaction/cycletransaction', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (74, N'cycleactions-newtransaction', N'New Transaction', NULL, 4, 4, 2, N'/cycleactions/newtransaction', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (75, N'cycleactions-updatenotification', N'Confirm Transaction', NULL, 4, 5, 2, N'/cycleactions/updatenotification', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (76, N'requests-newrequest', N'New Request', NULL, 2, 11, 2, N'/requests/newrequests', NULL, NULL)
GO
INSERT [dbo].[Permission] ([ID], [Name], [DisplayName], [Description], [ParentID], [Order], [PermissionType], [PermissionURL], [StyleClass], [IsDeleted]) VALUES (77, N'report-transactionproductdetails', N'Inventory Product Log', NULL, 3, 4, 2, N'/report/transactionproductdetails', NULL, NULL)
GO
