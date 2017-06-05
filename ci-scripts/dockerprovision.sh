DOCKER_UN="$1"
DOCKER_PW="$2"

docker login -u "$DOCKER_UN" -p "$DOCKER_PW" constructors.azurecr.io

docker pull constructors.azurecr.io/platforms/netcoresdk

echo "Creating container container-netcoresdk-$BUILD_BUILDNUMBER..."
docker create --name builder constructors.azurecr.io/platforms/netcoresdk

echo "Copying samples to container..."
docker cp "$BUILD_REPOSITORY_LOCALPATH/samples/." builder:/samples/

echo "Committing changes..."
docker commit builder constructors.azurecr.io/platforms/netcoresdk

docker run --name "container-netcoresdk-$BUILD_BUILDNUMBER" bash -c "for sample in $(find . -name *.csproj); do dotnet restore $sample; dotnet build $sample; done"

#docker run --name container-netcoresdk-305 --rm -v /opt/vsts/work/1/s:/source -w /source/samples/csharp constructors.azurecr.io/platforms/netcoresdk bash -c for sample in $(find . -name *.csproj); do dotnet restore $sample; dotnet build $sample; done
