<!DOCTYPE html>
<h1>:beginner:Sistema de Facturacion e Inventario</h1>
<p>:arrow_down_small:<strong>Ver mas...</strong></p>
<h3>Programacion Estructurada 07L <br>Grupo #2</h3>
<ul>
    <li>Rebeca Alvarenga</li>
    <li>Oscar Cañas</li>
    <li>Hugo Ortiz</li>
    <li>Geovanny Pineda</li>
    <li>Jefferson Menjivar</li>
</ul>
<hr>
<h1>Secciones</h1>
<ul>
  <li><a href = "#requisitos">Requisitos</a></li>
  <li><a href = "#acerca-de">Acerca del Proyecto</a></li>
  <li><a href = "#devs-only">Solo desarrolladores</a></li>
</ul>
<a name = "requisitos"></a>
<hr>
<h2>Requisitos</h2>
<p>Requisitos necesarios:</p>
<ul>
  <li><b><a href = "https://dotnet.microsoft.com/download/dotnet-framework/thank-you/net48-offline-installer">.NET Framework 4.8 </a></b> (requisito importante)</li>
  <li>Ejecutar el instalador <i>"setup.exe"</i> como administrador</li>
</ul>
<p><i>NOTA:</i> el no cumplir uno de estos requisitos pueda que la aplicacion no inicie y/o no se instale correctamente</p>
  <a name = "acerca-de"></a>
<hr>
<h2>Acerca del proyecto</h2>
<p>
  Version Actual: 0.51 Beta
  <br>
  Version estable el cual han sido corregido la mayoria de errores.
  <br>
  Esta version contiene 4 de 6 pantallas esperadas y una clase que aloja funciones basicas que se encuentran en todas las pantallas, reduciendo la cantidad de codigo utilizado.
  En esta version se corrigieron la mayor cantidad de errores en ciertas circunstancias y se implemento funciones extra como:
  <ul>
    <li>Fuente de instalador cambiado. Ahora se utiliza la extension <a href = "https://marketplace.visualstudio.com/items?itemName=VisualStudioClient.MicrosoftVisualStudio2017InstallerProjects">Visual Studio Installer Projects</a> como empaquetador en lugar del publicador ClickOnce de Visual Studio (el  problema surgido es el manifiesto del proyecto. Luego de instalar .NET Framework 4.8 seguia la instalacion de la aplicacion pero, debido a una incompatibilidad del manifiesto con las propiedades del proyecto original)</li>
  </ul>
</p>
<p>
  Para ver mas informacion, avance a la seccion <a href = "#devs-only"><b>Solo para desarrollador</b>
</p>
<h3>Licencias Utilizadas</h3>
<p>
  <b>Abstract Backgrounds</b>, por NichoDesign.<br>
  Licencia Creative Commons CC BY-NC-SA<br>
  <b>Multiples Iconos</b>, por Anonimo.<br>
  Licencia Creative Commons CC BY-NC
</p>
<a name = "devs-only"></a>
<hr>
<h1>Solo para desarrolladores</h1>
<p>
    Accesos directos a documentacion:
    <ol>
        <li><a href = "">Manual de Usuario</a></li>
        <li><a href = "">Calendario del proyecto</a></li>
        <li><a href = "">Funcionamiento Basico del Proyecto (Video)</a></li>
        <li><a href = "">Perfil de Proyecto</a></li>
    </ol>
</p>
<p>
    Para los usuarios, a cada usuario se le ha delimitado un numero de usuario de 4 digitos, con su respectivo nombre y contraseña.<br>
    Los usuarios con codigo 10XX son usuarios ADMINISTRADORES, los cuales tienen <b>Control Total</b> de la aplicacion. Estos pueden facturar y ver el inventario, asi como
    ver la localizacion de la carpeta donde se guardan las facturas, la localizacion de la carpeta de inventario y usuarios (<i>"product.txt" y "users.txt"</i>) o ver el 
    archivo <i>"product.txt"</i> (donde se guarda el inventario).<br>
    Los usuarios con codigo 20XX son usuarios USUARIOS, los cuales solo pueden facturar, no pueden ver el inventario ni las facturas.
</p>
