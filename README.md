# JocAmbDaus — Juego de dados y tablero (WinForms .NET Framework 4.7.2)

Juego local de 2 a 4 jugadores. Primero se tira el dado para decidir el orden de turno, luego las 4 fichas de cada jugador avanzan por un tablero de 100 casillas. Gana quien lleve todas sus fichas a la meta.

## Estructura

```
JocAmbDaus/
├── JocAmbDaus.sln
└── JocAmbDaus/
    ├── Form1.cs            # Flujo: registro → dados → partida, turnos, reglas + tema claro/oscuro
    ├── CLASSES/
    │   ├── ClJugador.cs    # nick, color, 4 fitxes
    │   ├── ClFitxa.cs      # PictureBox circular + animación MoureA
    │   ├── ClDau.cs        # Dado GDI+ con cara blanca
    │   └── ClTauler.cs     # Tablero 10x10 dibujado, 70px/casilla
    ├── Resources/
    │   └── goodresult-82807.mp3  # Sonido victoria (WMP)
    └── App.config
```

## Stack

- C# / .NET Framework 4.7.2 / WinForms (proyecto clásico, no SDK-style)
- GDI+ (`System.Drawing`), `PictureBox` + `Region` circular para fichas
- `WMPLib.WindowsMediaPlayer` para el sonido final
- Visual Studio 2022 con workload .NET desktop

## Cómo se juega

1. Elige 2-4 jugadores, pon nick y color (no se puede repetir color).
2. Fase dados: cada jugador clica su dado. Animación de 8-15 ticks. El valor más alto sale primero. Si hay empate, quien haya tirado primero queda por delante.
3. Fase tablero: se muestra `pnlTauler` 10x10 (70px, 700x700). Turnos automáticos cada 1,5s: se tira dado, la primera ficha no llegada avanza. Casella ocupada = no mueve. Al pasar de 100, la ficha va a meta y el sobrante mueve otra ficha.
4. Final: el panel se tiñe con el color del ganador, suena el mp3 y sale el MessageBox.
5. `Esc` cierra el juego. Cabecera con `✕` cerrar, `—` minimizar, `🌙/☀️` cambiar tema.

## Interfaz

- Tema oscuro por defecto + modo claro con el botón de la cabecera (`Form1.cs:AplicarTema`).
- Cabecera propia de 52px (el form es `Borderless`), con título, arrastre y botones.
- Botones redondeados con `Region` (`ArrodonirBoto`), dados con cara blanca para contraste.
- `GroupBox` sin texto para un aspecto limpio.

## Notas técnicas

- Fichas: `PictureBox` con `Region` elíptica + `DoubleBuffered` en tablero para que no se vea el fondo blanco rectangular al animar. Las fichas cuelgan de `gbDaus` para quedar a la altura del dado.
- Tablero sin marco exterior para evitar recortes asimétricos.
- Sin `Thread.Sleep` en el hilo UI: turnos y final usan `await Task.Delay` para no congelar el pintado.
- `tmrTorn.Tick` se desuscribe antes de suscribirse para no duplicar turnos al rejugar.
- `CasellaOcupada` ignora `-1` (fichas en salida/meta).

## Ejecución

- Windows + .NET Framework 4.7.2 (viene con Windows 10/11) + Visual Studio.
- Abrir `JocAmbDaus.sln`, F5 (Debug Any CPU).

```powershell
# Compilar sin VS (MSBuild)
& "C:\Program Files\Microsoft Visual Studio\2022\Community\Msbuild\Current\Bin\MSBuild.exe" JocAmbDaus.sln /p:Configuration=Debug /p:Platform="Any CPU"
```

## Licencia

MIT — ver [LICENSE](LICENSE).
