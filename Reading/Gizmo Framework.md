
# Design Patterns and SOLID Principles in the Gizmo Drawing Framework

## Design Patterns Utilized

### 1. Strategy Pattern
The Gizmo Drawing Framework leverages the **Strategy Pattern** by defining a common interface `IDrawGizmo` for all gizmo types. Each concrete implementation (e.g., `WireframeCubeGizmo`, `WireframeSphereGizmo`) encapsulates its unique drawing behavior. This allows the behavior of drawing gizmos to be easily interchangeable at runtime, promoting flexibility and reusability.

- **Example:** `WireframeCubeGizmo`, `WireframeSphereGizmo`, `WireframeArrowGizmo` implement the `IDrawGizmo` interface, providing distinct implementations of the `Draw` method.

### 2. Template Method Pattern
The abstract base class `DrawGizmo` serves as a template for creating specific gizmos. It provides shared functionality (e.g., `gizmoColor`) and defines the `Draw` method as a virtual method that concrete classes override to implement shape-specific behavior.

- **Example:** The `Draw` method in `DrawGizmo` is overridden by each concrete class to provide shape-specific drawing logic.

## SOLID Principles Utilized

### 1. Single Responsibility Principle (SRP)
Each class in the framework has a single, well-defined responsibility. For instance:
- `WireframeCubeGizmo` is responsible only for drawing a wireframe cube.
- `GizmoDrawer` is responsible for managing the integration of a gizmo with a Unity `GameObject`.

This separation ensures that changes to one part of the system do not affect unrelated components.

### 2. Open/Closed Principle (OCP)
The framework is open for extension but closed for modification. Adding a new gizmo type involves creating a new class that implements `IDrawGizmo` or extends `DrawGizmo`, without altering existing code.

- **Example:** Adding a `WireframeOctahedronGizmo` simply involves defining a new class that implements the `Draw` method.

### 3. Liskov Substitution Principle (LSP)
Concrete gizmo classes can be substituted wherever `IDrawGizmo` is expected, ensuring consistent behavior.

- **Example:** `WireframeSphereGizmo` and `WireframeCubeGizmo` can be interchanged in `GizmoDrawer` without requiring changes to its implementation.

### 4. Interface Segregation Principle (ISP)
The `IDrawGizmo` interface is narrowly focused, containing only the `Draw` method, which is essential for all gizmo types. This ensures that classes implementing the interface are not burdened with unnecessary methods.

### 5. Dependency Inversion Principle (DIP)
High-level modules (e.g., `GizmoDrawer`) depend on abstractions (`IDrawGizmo`) rather than concrete implementations. This decoupling allows the framework to remain flexible and extensible.

- **Example:** `GizmoDrawer` interacts with `IDrawGizmo` rather than directly referencing specific gizmo types.

## Conclusion

The Gizmo Drawing Framework is a robust implementation of design patterns and SOLID principles. By employing the **Strategy** and **Template Method** patterns and adhering to SOLID principles, the framework achieves high cohesion, low coupling, and significant flexibility for future extensions.
