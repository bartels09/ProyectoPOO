/**
 *
 * @author Freddy
 */
package logica;

import java.util.List;
import modelo.Usuario;



public class Autenticacion {
    public boolean autenticacionCorrecta(List<Usuario> usuariosRegistrados,
            String usuarioIngresado, String contraseniaIngresada){
        for(Usuario u : usuariosRegistrados){
            if (u.getNombreUsuario().equals(usuarioIngresado)
                && u.getClave().equals(contraseniaIngresada)){
                return true;
            }
        }
        return false;
    }
}
