#!/bin/bash
set -a
source file.env
set +a
exec dotnet Havesh.Silo.dll
