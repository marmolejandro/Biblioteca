# PruebaIngresoBibliotecario

Reto técnico en donde se requiere un API REST para generar prestamos de libros para 3 tipos de usuario (Afiliado, Empleado e Invitado)


Reglas de negocio ---------------------------------------------------------------------------------------

- Respecto a los tipos de usuario:
    - Afiliado [1]:
        - Puede prestar hasta n cantidad de libros.
        - Fecha de devolución después de 10 días sin contar sábados ni domingos.

    - Empleado [2]:
        - Puede prestar hasta n cantidad de libros.
        - Fecha de devolución después de 8 días sin contar sábados ni domingos.

    - Invitado [3]:
        - Puede prestar hasta 1 libro.
        - Fecha de devolución después de 7 días sin contar sábados ni domingos.

- La identificación de un usuario no puede contener mas de 10 caracteres.