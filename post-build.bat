REM Paste everything below into the Post-Build Events of the project. Set Testing=1 to be able to run unit tests.
SET Testing=0
IF %Testing% == 0 (
  CD "$(SolutionDir)"
  IF "$(ConfigurationName)" == "Debug" (
    build-plgx.bat --debug
  ) ELSE (
    build-plgx.bat
  )
)