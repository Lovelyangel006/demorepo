pipeline {
    agent any

    environment {
        DOTNET_SDK_VERSION = '5.0' // Specify the .NET SDK version you are using
    }

    stages {
        stage('Checkout') {
            steps {
                   git branch: 'master', url: 'https://github.com/Lovelyangel006/demorepo.git'
            }
        }

        stage('Restore') {
            steps {
               
                    sh 'dotnet restore'
            }
        }

        stage('Build') {
            steps {
                sh 'dotnet build --configuration Release --no-restore'
            }
        }

        stage('Test') {
            steps {
                sh 'dotnet test --no-build'
            }
        }
    }

    post {
        always {
            archiveArtifacts artifacts: '**/bin/**/*.dll', allowEmptyArchive: true
            junit 'TestResults/*.xml'
        }
        success {
            echo 'Build succeeded!'
        }
        failure {
            echo 'Build failed!'
        }
    }
}

