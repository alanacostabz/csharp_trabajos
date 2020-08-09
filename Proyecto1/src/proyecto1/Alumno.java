/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package proyecto1;

/**
 *
 * @author dii
 */
public class Alumno {

    public int expediente;
    public String nombre;
    public String apellidos;
    public boolean activo;
    public String fechaNacimiento;

    public Alumno() {
        //super();
        System.out.println("Alumno nuevo");
    }

    public Alumno(int expediente, String nombre, String apellidos) {
        System.out.println("Constructor con parametros");
        this.expediente = expediente;
        this.nombre = nombre;
        this.apellidos = apellidos;
        
        //this apunta clase
        //super apunta al papá
    }
}
   