FROM jenkins/jenkins AS base
#FROM jenkins/jenkins:lts AS base

USER root
ENV TZ=Europe/Paris
#Pour Git

RUN ln -snf /usr/share/zoneinfo/$TZ /etc/localtime && echo $TZ > /etc/timezone
RUN apt-get update && apt-get upgrade -y
RUN apt-get install -y software-properties-common wget
RUN apt-get install -y git default-jdk
RUN apt-get install -y apt-transport-https docker.io  && rm -rf /var/lib/apt/lists/*
RUN wget https://packages.microsoft.com/config/ubuntu/20.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
RUN dpkg -i packages-microsoft-prod.deb
RUN apt-get update

#RUN apt-get install -y dotnet-runtime-3.1 aspnetcore-runtime-3.1 
RUN apt-get install -y dotnet-sdk-5.0 
RUN dotnet tool install --global dotnet-sonarscanner
RUN dotnet tool install --global dotnet-reportgenerator-globaltool
# RUN export PATH="$PATH:/root/.dotnet/tools"
ENV PATH="${PATH}:/root/.dotnet/tools"

RUN dotnet nuget add source http://nexus:8081/repository/nuget-hosted/


RUN mkdir /app

