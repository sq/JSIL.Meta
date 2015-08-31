#!/bin/bash

# installs the PCL reference assemblies so that xbuild can build jsil.meta
# http://blog.csmac.nz/travis-ci-c-and-pcl/

# make sure to run this with 'source' i.e. 
#   source ./install-pci-reference-assemblies.sh
# or
#   . ./install-pci-reference-assemblies.sh

SCRIPTPATH=`realpath "$BASH_SOURCE"`
DIRNAME=`dirname $SCRIPTPATH`
OUTDIR=$DIRNAME/temp

if [ -d "$OUTDIR/pcl-assemblies" ]; then
  echo PCL assemblies already installed, not downloading again.
else
  echo Installing PCL assemblies...
  curl -sS http://storage.bos.xamarin.com/bot-provisioning/PortableReferenceAssemblies-2014-04-14.zip --output /tmp/pcl-assemblies.zip
  rm -rf $OUTDIR
  mkdir $OUTDIR
  unzip -o -q /tmp/pcl-assemblies.zip -d $OUTDIR/pcl-assemblies && mv $OUTDIR/pcl-assemblies/PortableReferenceAssemblies-2014-04-14 $OUTDIR/pcl-assemblies/.NETPortable
  echo ... installed PCL assemblies to '$OUTDIR'.
fi

export XBUILD_FRAMEWORK_FOLDERS_PATH=$OUTDIR/pcl-assemblies
