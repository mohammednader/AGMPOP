using System;
using System.Collections.Generic;
using System.Text;

namespace AGMPOP.BL.Models.ViewModels
{
    public class POPEnums
    {

        public enum JobTitle
        {
            BBX = 1,
            HeadRunner = 2,
            Runner = 3,
            ActiveAgent = 4
        }

        public enum TransactionStatus
        {
            NewRequst = 1,
            Pending = 2,
            Confirmed = 3,
            Canceled = 4
           
        }



        public enum CycleStatus
        {

            Running = 1,
            New = 2,
            Ended = 3
        }
        public enum UserType
        {
            Runner = 1,
            SubRunner = 2
        }
        public enum RoleType
        {

            SystemRole,
            UserDefined

        }

        public enum JobType
        {
            UserDefined = 1,
            SystemJob = 2

        }

        public enum CycleType
        {
            NationWide = 1,
            Event = 2,
        }
        public enum ProductType
        {
            BBO = 1,
            Product = 2
        }



        public enum TransactionTypes
        {
            Delivery = 1,
            Return = 2,
            Transfer = 3,
            Clearance = 4,
        }


        public enum RequstStatus
        {
            Pending = 1,
            Received = 2
        }

        public enum SendEmailWay
        {
            WebConfig = 1,
            DataBase = 2
        }

        public enum NotificationType
        {
            NotConfirmed = 1,
            Confirmed = 2
        }

        public enum InventoryActionType
        {
            Increment = 1,
            Decrement = 2,
        }

        public enum AuditActionType
        {
            Insert = 1,
            Update = 2,
            Delete = 3,
        }
    }
}
