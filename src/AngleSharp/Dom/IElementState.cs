namespace AngleSharp.Dom {

/// <summary>
/// A fully agnostic state interface that allows clients to fully overload the pseudo-class behaviour
/// </summary>

public interface IElementState {

    /// <summary>
    /// Returns true if the thing the element represents is in focus
    /// </summary>
    bool IsFocused { get; }
    /// <summary>
    /// Returns true if the thing the element represents is being hovered
    /// </summary>
    bool IsHovered { get; }

    /// <summary>
    /// Returns true if the thing the element represents has been visited
    /// </summary>

    bool IsVisited { get;  }

    /// <summary>
    /// Returns true if the thing the element represents is enabled
    /// </summary>

    bool IsEnabled { get;  }

    /// <summary>
    /// Returns true if the thing the element represents is in disabled
    /// </summary>

    bool IsDisabled { get;  }

    /// <summary>
    /// Returns true if the thing the element represents is in default state
    /// </summary>

    bool IsDefault { get; }

    /// <summary>
    /// Returns true if the thing the element represents is visible
    /// </summary>
    bool IsVisible { get; }

    /// <summary>
    /// Returns true if the thing the element represents is being hidden
    /// </summary>
    bool IsHidden { get; }

    /// <summary>
    /// Returns true if the thing the element represents is being hidden
    /// </summary>
    bool IsPrimaryDown { get; }
    /// <summary>
    /// Returns true if the thing the element represents is being hidden
    /// </summary>
    bool IsPrimaryDownEdge { get; }

    /// <summary>
    /// Returns true if the thing the element represents is being hidden
    /// </summary>
    bool IsPrimaryUp { get; }

    /// <summary>
    /// Returns true if the thing the element represents is being hidden
    /// </summary>
    bool IsPrimaryUpEdge { get; }

    /// <summary>
    /// Returns true if the thing the element represents is being hidden
    /// </summary>
    bool IsSecondaryDown { get; }

    /// <summary>
    /// Returns true if the thing the element represents is being hidden
    /// </summary>
    bool IsSecondaryDownEdge { get; }

    /// <summary>
    /// Returns true if the thing the element represents is being hidden
    /// </summary>
    bool IsSecondaryUp { get; }

    /// <summary>
    /// Returns true if the thing the element represents is being hidden
    /// </summary>
    bool IsSecondaryUpEdge { get; }

    /// <summary>
    /// Returns true if the thing the element represents is being hidden
    /// </summary>
    bool IsButtonCold { get; }

    /// <summary>
    /// Returns true if the thing the element represents is being hidden
    /// </summary>
    bool IsButtonPrimed { get; }

    /// <summary>
    /// Returns true if the thing the element represents is being hidden
    /// </summary>
    bool IsButtonActioned { get; }

    /// <summary>
    /// Returns true if the thing the element represents is being hidden
    /// </summary>
    bool IsButtonCanceled { get; }

    /// <summary>
    /// Returns true if the thing the element represents is being hidden
    /// </summary>
    bool IsButtonDenied { get; }

}
}