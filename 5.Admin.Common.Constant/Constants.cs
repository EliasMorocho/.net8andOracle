namespace Admin.Common.Constant
{
    public static class Constants
    {
        public const string List_CUSTOMERS = "Customers";
        public const string List_ACCOUNT = "Accounts";
        public const string List_LOANREQUEST = "Loanrequests";
        public const string List_CONFIGURATION = "Configuration";
    }

    public static class CustomerStatus
    {
        public const string Registered = "Registrado";
        public const string Updated = "Actualizado";
        public const string Pending_Approval = "En Aprobación";
        public const string UnderReview = "En Revisión";
        public const string Approved = "Aprobado";
        public const string Rejected = "Rechazado";
        public const string Disbursed = "Desembolsado";
        public const string Active = "Activo";
        public const string InacActive = "Inactivo";
        public const string Paid = "Liquidada";
        public const string Pending = "Pendiente";
        public const string Payment = "Pago de Cuota";
    }

    public static class Roles
    {
        public const string Administrador = "Administrador";
        public const string Agente = "Agente";
        public const string AnalistaCredito = "Analista de Crédito";
        public const string GestorPagos = "Gestor de Pagos";
        public const string Cobrador = "Cobrador";
    }

    public static class PaymentPlanConstants
    {
        public const string Monthly = "Mensual";
        public const string BiWeekly = "Quincenal";
        public const string Weekly = "Semanal";
        public const string Daily = "Diario";
    }
}