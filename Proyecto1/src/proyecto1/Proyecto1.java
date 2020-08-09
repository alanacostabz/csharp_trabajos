package proyecto1;

import javax.swing.JOptionPane;

public class Proyecto1 {

    public static void main(String[] args) {
       // JOptionPane.showMessageDialog(null, "Este no debe ejecturase");
        
       // Alumno alumno = new Alumno(); 
       Alumno garcia = new Alumno(12345, "Luis", "García");
        System.out.println(garcia.expediente + "\n" + garcia.nombre + "\n" + garcia.apellidos);
        
    }

}
