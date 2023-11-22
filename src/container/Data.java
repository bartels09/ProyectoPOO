/**
 *
 * @author Freddy
 */
package container;

import modelo.*;
import java.util.*;


public class Data {
    
    List<Cliente> clientes = new ArrayList<>();
    List<Usuario> usuarios = new ArrayList<>();
    List<Ejercicio> ejercicios = new ArrayList<>();

    public List<Ejercicio> getEjercicios() {
        return ejercicios;
    }

    public void setEjercicios(List<Ejercicio> ejercicios) {
        this.ejercicios = ejercicios;
    }
    
    public List<Cliente> getClientes() {
        return clientes;
    }

    public void setClientes(List<Cliente> clientes) {
        this.clientes = clientes;
    }

    public List<Usuario> getUsuarios() {
        return usuarios;
    }

    public void setUsuarios(List<Usuario> usuarios) {
        this.usuarios = usuarios;
    }
    
    public Data(){
        Usuario u1 = new Usuario();
        u1.setCedula("116550629");
        u1.setNombre("Freddy Castro");
        u1.setNombreUsuario("bartels09");
        u1.setClave("1234");
    
        Usuario u2 = new Usuario();
        u2.setCedula("1");
        u2.setNombre("cliente1");
        u2.setNombreUsuario("cliente1");
        u2.setClave("4321");
        
        usuarios.add(u1);
        usuarios.add(u2);
    }
}
