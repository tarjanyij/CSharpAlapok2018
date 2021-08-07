# A kiindulási paramétererk
FROM microsoft/dotnet:sdk AS buildenv
WORKDIR /app

# átmásoljuk a projekt fájlt a konténerbe
COPY *.csproj ./app

# lefuttatjuk a dotnet restore-t
RUN dotnet restore

# minden mást átmásolunk
COPY . ./

# elkészítjük a buildet
RUN dotnet publish -c Release -o out

# RUNTIME IMAGET
FROM microsoft/dotnet:aspnetcore-runtime
WORKDIR /app

#átmásoljuk az első konténerből a másodikba  az alkalmazást
COPY --from=buildenv /app/out

#alkalmazás indítása
ENTRYPOINT ["dotnet","02ienurable.dll"]

