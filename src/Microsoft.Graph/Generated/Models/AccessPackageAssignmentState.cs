namespace Microsoft.Graph.Models {
    /// <summary>Provides operations to manage the appCatalogs singleton.</summary>
    public enum AccessPackageAssignmentState {
        Delivering,
        PartiallyDelivered,
        Delivered,
        Expired,
        DeliveryFailed,
        UnknownFutureValue,
    }
}
