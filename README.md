# Examen Windows Forms Mañana
Crea una aplicación de gestión de empleados con los siguientes requisitos:
1. Debes utilizar al menos tres formularios diferentes: uno para ingresar nuevos empleados, otro para mostrar la lista de empleados y un tercero para mostrar detalles específicos de un empleado seleccionado.
2. En el formulario de ingreso de empleados, se deben solicitar los siguientes datos al usuario:
    - Nombre completo del empleado (TextBox)
    - Departamento al que pertenece (ComboBox)
    - Edad del empleado (MaskedTextBox con validación numérica)
    - Estado civil del empleado (RadioButton)
    - Habilidades del empleado (CheckBoxes)
3. Debes implementar una clase abstracta llamada Empleado que contenga propiedades para el nombre completo, departamento y edad del empleado. Además, esta clase debe tener una propiedad abstracta llamada EstadoCivil de tipo string.
4. Crea una clase concreta llamada EmpleadoInformatico que herede de la clase abstracta Empleado. Esta clase debe tener una propiedad adicional llamada LenguajesProgramacion que permita al empleado seleccionar múltiples lenguajes de programación en una lista desplegable (ComboBox) o una lista de selección múltiple (ListBox).
5. En el formulario de lista de empleados, muestra la información básica de todos los empleados ingresados (nombre, departamento y edad). Utiliza un control ListBox o ListView para mostrar los datos en un formato legible. Al seleccionar un empleado de la lista, se debe abrir el formulario de detalles del empleado.
6. En el formulario de detalles del empleado, muestra toda la información del empleado seleccionado, incluyendo su estado civil y habilidades. Utiliza controles de etiqueta (Label), cuadro de texto (TextBox), lista desplegable (ComboBox), cuadro de selección (CheckBox) y un control ListBox o ListView para mostrar las habilidades del empleado.

Asegúrate de que utilizas componentes de validación adecuados para los campos obligatorios y formatos de entrada correctos. Por ejemplo, el nombre del empleado no debe estar vacío, la edad debe ser un número válido, etc.

Evalúa la correcta implementación de la herencia utilizando una clase abstracta y una clase concreta.

Valora la utilización adecuada de los controles y componentes requeridos, como etiquetas, cuadros de texto, listas desplegables, cuadros de selección, cuadros de diálogo de mensaje y controles ListBox o ListView.
