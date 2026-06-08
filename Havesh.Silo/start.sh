#!/bin/bash
if [ -s file.env ]; then
  set -a
  source file.env
  set +a
fi
exec dotnet Havesh.Silo.dll
