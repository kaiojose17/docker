FROM mcr.microsoft.com/dotnet/core/sdk:2.1
LABEL version="1.0.0" description="MVC" maintainer="Jose Kaio"
COPY dist /app
WORKDIR /app
EXPOSE 80/tcp
ENTRYPOINT [ "dotnet", "mvc.dll" ]