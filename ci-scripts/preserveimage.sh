mkdir buildimage
docker save -o "$BUILD_REPOSITORY_LOCALPATH/buildimage" "constructors.azurecr.io/platforms/netcoresdk"
