pipeline {
    agent any

    environment {
        DOTNET_SDK_VERSION = '8.0' // Specify the .NET SDK version you are using
    }

    stages {
        stage('Checkout') {
            steps {
                   git branch: 'master', url: 'https://github.com/Lovelyangel006/demorepo.git'
            }
        }

        stage('Restore') {
            steps {
                
                bat 'dotnet --info'
                dir('AngularCrudWebapi/AngularCrudWebapi')
                {
                bat 'dotnet restore'
            }
        }         
    }
        }
}

